using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Book
    {

        private string Title;
        private String Author;
        private String ISBN;

        // Title property to allow access to the title private variable
        public string Title
        {
            get { return Title; } // Get method
            set { Title = value; } // Set method
        }

        // Author property to allow access to the Author private variable
        public string Author
        {
            get { return Author; } // Get method
            set { Author = value; } // Set method
        }

        // ISBN property to allow access to the ISBN private variable
        public string ISBN
        {
            get { return ISBN; } // Get method
            set { ISBN = value; } // Set method
        }

        // Example of a constructor that allows us to "construct" a new Book object
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        { 
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        

        }
    }



    


