using System;
namespace Chapter14;

public class Book
{
    //Question 20
    public string BookTitle{get; set;}
    public string BookAuthor{get; set;}
    public string Publisher{get; set;}
    public static  string LibraryName = "Welcome to CLH Library";
    public DateTime ReleasedDate{get;}
    public int ISBN{get; set;}
    public Book(string bookTitle, string bookAuthor, string publisher, DateTime releasedDate, int isbn)
    {
        BookTitle = bookTitle;
        BookAuthor = bookAuthor;
        Publisher = publisher;
        ReleasedDate = releasedDate;
        ISBN = isbn;
    }
}