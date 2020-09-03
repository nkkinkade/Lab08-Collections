using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net;
using System.Text.Json;

namespace Collections
{
    class Program
    {
        public static Library<Book> Library { get; set; }

        public static List<Book> BookBag { get; set; }
        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new List<Book>();

            LoadBooks();
        }

        static void LoadBooks()
        {
            AddABook("Harry Potter and the Prisoner of Azkaban", "JK", "Rowling", 435, Genre.Fantasy);
            AddABook("A Song of Ice and Fire", "George RR", "Martin", 694, Genre.Fantasy);
            AddABook("It", "Stephen", "King", 1138, Genre.Horror);
            AddABook("Catching Fire", "Suzanne", "Collins", 391, Genre.Action);
            AddABook("1984", "George", "Orwell", 328, Genre.Scifi);
            foreach(Book book in Library)
            {
                Console.WriteLine($"{book.Title}, {book.Author.FirstName} {book.Author.LastName}, {book.Genre}");
            }
            
        }
        static void AddABook(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            Book book = new Book()
            {
                Title = title,
                Author = new Author(firstName, lastName)
                {
                    FirstName = firstName,
                    LastName = lastName
                },
                NumberOfPages = numberOfPages,
                Genre = genre
            };

            Library.Add(book);
        }

    }
}
