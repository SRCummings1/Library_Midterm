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
            new Book("The Two Towers","J.R.R. Tolkien", "Fantasy" ),
            new Book("Murder on the Orient Express","Agatha Cristy", "Mystery" ),
            new Book("Foundation","Isaac Asimov", "Sci-Fi" ),
            new Book("Born to Run","Michael Pollen", "Non-Fiction" ),
            new Book("Return of the Kind","J.R.R. Tolkien", "Fantasy" ),
            new Book("The Stand","Steven King", "Fantasy" ),
            new Book("Goosebumps","R.L. Stine", "Young Adult" ),
            new Book("To Kill a Mockingbird","Harper Lee", "Fiction" ),
            new Book("The Great Gatsby","F. Scott Fitzegerald", "Fiction" ),
            new Book("War and Peace","Leo Tolstoy", "Fiction", false ),
            new Book("The Road", "Phillip Myier", "Fiction", false),
            new Book("The Call of the Wild", "Jack London", "Fiction")
       
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
            Status = true;

        }

    }
}
