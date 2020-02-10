using System;
using System.Collections.Generic;
using System.Linq;

namespace Library_Terminal_Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Class Program -Logic- (Promps, Inputs, Outputs)(If statements, Switch statements)
            Console.WriteLine("Hello, welcome to the Library.");
            while (true)
            {


                DisplayMenu();//Calling the Method
                string selection = GetUserInput("Please Make A Selection From Above: ");

                switch (selection)

                {
                    case "1":
                        DisplayAllBooks();
                        // DisplayBooks();
                        //TODO: Display All Books
                        //Call to Display all books by Method!!
                        break;
                    case "2":
                        DisplayAuthors();
                        // DisplayAuthor();
                        //TODO: Display Books By Author
                        //Call to Diplay books by author Method!!
                        break;
                    //TODO: Display All Books By Title
                    //Call to Diplay books by author Method!!
                    case "3":
                        DisplayTitles();
                        break;
                   
                    case "4":
                        DisplayGenre();
                        string userInput = GetUserInput("Select a genre");
                        string userGenre = GetGenre(userInput);
                        DisplayBooksByGenre(userGenre);
                        break;
                    //TODO: Check out Book
                    //Call to Check Status
                    case "5":
                        DisplayTitles();
                        string input = GetUserInput("What book would you like to Check Out : ");
                        CheckOutBook(input);

                        //DisplayAllBooks();
                        //string response2 = GetUserInput("Which book would you like to check out? ");
                        //int index = int.Parse(response2) - 1;
                        //Book.Books[index].Checkout();
                        break;
                    //TODO: Leave Library

                    case "6":
                        DisplayTitles();
                        input = GetUserInput("What book would you like to Check In : ");
                        CheckInBook(input);
                        break;
                    case "7":
                        Console.Write("Goodbye.");
                        Environment.Exit(0);
                        break;
                    default:
                        //TODO: Keep Looping??
                        break;
                }
            }
        }
        public static void DisplayMenu()//Check book by Genre
        {
            Console.WriteLine(" [1]: Display All Books \n [2]: Display Books by Author \n [3]: Display Books by Title \n [4]: Check book genres \n [5]: Check out book \n [6]: Check in book \n[7]: Leave Library");
        }
        public static void DisplayBooks()
        {
            for (int i = 0; i < Book.Books.Count; i++)
            {
                Console.WriteLine($"{Book.Books[i].Title}\t");
                Console.WriteLine();
                Console.WriteLine($"{Book.Books[i].Author}\t");
                Console.WriteLine();
                Console.WriteLine($"{Book.Books[i].Genre}\t");
                Console.WriteLine();
                Console.WriteLine($"{Book.Books[i].Status}\t");
                Console.WriteLine();
                //if (book.Status == true)
                //{
                //    Console.WriteLine($" Status : on Shelf \n");
                //}
                //else
                //{
                //    Console.WriteLine($"Status: Checked out");
                //    Console.WriteLine($"The books due date is: {Book.DueDate.To");
                //}


            }
        }

        public static void DisplayAuthor()
        {
            for (int i = 0; i < Book.Books.Count; i++)
            {

            }
        }
        public static void AuthorList()
        {
            for (int i = 0; i < Book.Books.Count; i++)
            {
                //diplay all authors and select author
                //select author and then print title
            }
        }
        public static void DisplayTitle()
        {
            for (int i = 0; i < Book.Books.Count; i++)
            {
                Console.WriteLine($"{Book.Books[i].Title}\t");
            }
        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        public static void DisplayBooksByGenre(string selection)
        {
            foreach (Book book in Book.Books)
            {
                if (book.Genre == selection)
                {
                    Console.WriteLine(book.Title);
                    Console.WriteLine(book.Author);
                    Console.WriteLine(book.Genre);
                    Console.WriteLine(book.Status);
                }
            }
        }


        //public static void DisplayBooksByGenre(string selection)

        //{

        //    List<string> genres = new List<string>(); // creating a blank list!
        //    for (int i = 0; i < Book.Books.Count; i++)
        //    {
        //        if (!genres.Contains(Book.Books[i].Genre))
        //        {
        //            genres.Add($"{Book.Books[i].Genre}"); // ++count;
        //        }
        //    }
        //    int count = 1;
        //    foreach (string genre in genres)
        //    {
        //        Console.WriteLine($"[{ count}] {genre}");
        //        count++;
        //        Console.WriteLine("=================================================================");
        //    }

        //    string userSelection = GetUserInput("Which genre would you like to see? ").ToLower();
        //    if (userSelection == "fantasy" || userSelection == "1")
        //    {
        //        Console.WriteLine("The Hobbit, The Fellowship of The Ring, The Two Towers, Return of the King, The Stand");
        //    }
        //    else if (userSelection == "Mystery" || userSelection == "2")
        //    {
        //        Console.WriteLine("Murder On The Orient Express");
        //    }
        //    else if (userSelection == "Sci-Fi" || userSelection == "3")
        //    {
        //        Console.WriteLine("The Foundation");
        //    }
        //    else if (userSelection == "Non-Fiction" || userSelection == "4")
        //    {
        //        return NonFiction;
        //    }
        //    else if (userSelection == "Young Adult" || userSelection == "5")
        //    {
        //        Console.WriteLine("A Wrinkle in Time");
        //    }
        //    else if (userSelection == "Fiction" || userSelection == "6")
        //    {
        //        Console.WriteLine("To Kill a Mockingbird, The Great Gatsby, The Call of the Wild");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid entry please try again");
        //    }
        //}
        //foreach(Book book in Book.Books)
        //{
        //    if (book.Genre.Contains(selection))
        //    {
        //        Console.WriteLine(book.Title);
        //        Console.WriteLine(book.Author);
        //        Console.WriteLine(book.Genre);
        //        Console.WriteLine(book.Status);
        //    }
        //}


        public static void DisplayAllBooks()
        {
            int count = 1;
            foreach (Book book in Book.Books)
            {
                Console.WriteLine($"[{ count}]   Title: {book.Title}");
                Console.WriteLine($"\t Author: {book.Author}");
                Console.WriteLine($"\t Genre: {book.Genre}");
                if (book.Status == true)
                {
                    Console.WriteLine($"\t Status: On Shelf");
                }
                else
                {
                    Console.WriteLine($"\t Status: Checked Out");
                }
                count++;
            }
        }

        public static void DisplayAuthors()
        {

            List<string> authors = new List<string>();

            for (int i = 0; i < Book.Books.Count; i++)
            {
                if (!authors.Contains(Book.Books[i].Author))
                {
                    authors.Add(Book.Books[i].Author);
                }
            }
            foreach (string author in authors)
            {
                Console.WriteLine(author);
            }
        }

        public static void DisplayTitles()
        {
            int count = 1;
            foreach (Book book in Book.Books)
            {

                {
                    Console.WriteLine($"{ count}: {book.Title}");
                    count++;
                }
            }
        }


        public static void CheckInBook(string title)
        {
            foreach (Book book in Book.Books)
            {
                if (book.Title == title)
                {
                    if (!book.Status)
                    {
                        book.Status = true;
                        book.DueDate = DateTime.Now;
                        Console.WriteLine($"{title} checked in.");
                    }
                    else
                    {
                        Console.WriteLine($"{title} is not avalaible");

                    }
                }
            }
        }
        public static void CheckOutBook(string title)
        {
            foreach (Book book in Book.Books)
            {
                if (book.Title == title)
                {
                    if (book.Status)
                    {
                        book.Status = false;
                        book.DueDate = DateTime.Now.AddDays(14);
                        Console.WriteLine($"{title} checked out and is due on {book.DueDate}");
                    }
                    else
                    {
                        Console.WriteLine($"{title} is not avalaible");

                    }
                }
            }
        }


        public static string GetGenre(string response)
        {
            if (response == "1")
            {
                return "Fantasy";
            }
            else if (response == "2")
            {
                return "Sci-Fi";
            }
            else if (response == "3")
            {
                return "Non-Fiction";
            }
            else if (response == "4")
            {
                return "Mystery";
            }
            else if (response == "5")
            {
                return "Young Adult";
            }
            else if (response == "6")
            {
                return "Fiction";
            }
            else
            {
                Console.WriteLine("Invalid Selection");
                response = GetUserInput("Selection Genre: ");
                return GetGenre(response);
            }
        }


        public static void DisplayGenre()
        {
            List<string> genres = new List<string>();
            foreach (Book book in Book.Books)
            {
                if (!genres.Contains(book.Genre))
                {
                    genres.Add(book.Genre);
                }
            }
            for (int i = 0; i < genres.Count; i++)
            {
                Console.WriteLine($"[{i + 1}]: {genres[i]}");
            }
        }
    }
}