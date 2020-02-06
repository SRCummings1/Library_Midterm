using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Terminal_Midterm
{
    class Book
    {

        public static List<Book> Books = new List<Book>()
        {
            new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy"),
            new Book("Fellowship of the Ring","J.R.R. Tolkien", "Fantasy"),
            new Book("The Two Towers","J.R.R. Tolkien", "Fantasy" )
        };     
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool Status  { get; set; }
        public DateTime DueDate { get; set; }

        public Book()
        {
            Status = true;
        }
        public Book(string title, string author, string genre, bool status = true)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Status = status;
        }
    
    }
}
