using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {

        public string Title;
        public String Author;
        public String ISBN;

       // Example of a constructor that allows us to "construct" a new Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        { 
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
            // Create new instance (object) of the book class
            Book book3 = new Book("Harry Potter", "JK Rowing", "18273645");

            
            book3.DisplayInfo();

        }
    }
}


    


