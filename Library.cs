using System;
using System.Collections.Generic;

namespace Chapter14;

public class Library
{
    //Question 20
    public static List<Book> books = new List<Book>();
    public Library()
    {
     //AddBooks();   
    }
   // public void AddBooks()
   // {
       // books.Add(this);
   // }
    public static void SearchBook(string name)
    {
        foreach (var book in books)
        {
            if (book.BookTitle == name)
            {
                Console.WriteLine($" The Book TiTle is: {book.BookTitle} and the Author is: {book.BookAuthor}");   
            }

            Console.WriteLine("Book not found");
        }
    }
    public static void BookInfo()
    {
        for(int i = 0; i < books.Count; i ++)
        {
            Console.WriteLine($"The title of book {i + 1} is {books[i].BookTitle}, and the author of the book is {books[i].BookAuthor} the book was released on the {DateTime.Now} while trhe Isbn number is {books[i].ISBN}");
        }
    }
    public static void DeleteBook(string name)
    {
        foreach (var item in books)
        {
            if(item.BookTitle == name)
            {
                books.Remove(item);
                Console.WriteLine($"The book {item.BookTitle} successfully Deleted");
            }
        }
    }
}