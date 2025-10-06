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

        void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Create a new instance (object) of the Book class)
            // Note how thw object name differs from the class name
            Book myBook = new Book();

            // This information is for one of the books in our library  
            myBook.Title = "C# for beginners";
            myBook.Author = "Bill Gates";
            myBook.ISBN = "212345678";

            // Create another book
            Book book2 = new Book();

            book2.Title = "C# Methods";
            book2.Author = "Microsoft";
            book2.ISBN = "87654321";



            myBook.DisplayInfo();
            book2.DisplayInfo();

        }
    }
}


    


