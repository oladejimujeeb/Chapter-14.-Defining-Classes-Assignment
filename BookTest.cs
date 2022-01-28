using System;

namespace Chapter14
{
    class BookTest
    {
        public static void LibraryMenu()
        {
            while (true)
            {
                Console.WriteLine("Enetr 1 to register a book\n Enter 2 to delete, search and get book info");
                int input = Convert.ToInt32(Console.ReadLine());
                if(input==1) BookTest.BookResgister();
                if(input==2) BookTest.GetBookInfo();
                else
                {
                    break;
                }
            }
        }
        
        private static void BookResgister()
        {
            Console.WriteLine(Book.LibraryName);
            Console.WriteLine("How many books did you want to save in the library");
            int bookNumbers = Convert.ToInt32(Console.ReadLine());
            for (var i = 0; i < bookNumbers; i++)
            {
                Console.WriteLine("Enter the book title: ");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the book Author: ");
                string author = Console.ReadLine();
                Console.WriteLine("publisher name: ");
                string publisher = Console.ReadLine();
                Console.WriteLine("Enter book ISBN: ");
                int isbn = Convert.ToInt32(Console.ReadLine());
                Book newBook = new Book(title, author, publisher, DateTime.Now, isbn);
                Library.books.Add(newBook);
            }
        }

        private static void GetBookInfo()
        {
            Console.Write("Enter 1 to get All book info\nEnter 2 to get Search for book\n Enter 3 to delete book");
            int input =Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Library.BookInfo();
                    break;
                case 2:
                    Console.WriteLine("Enter the author name of the book you want to search");
                    string author =Console.ReadLine();
                    Library.SearchBook(author);
                    break;
                case 3 :
                    Console.WriteLine("Enter the author name of the book you want to delete");
                    string name =Console.ReadLine();
                    Library.DeleteBook(name);
                    break;
                default:
                    break;
            }

        }
    }
}