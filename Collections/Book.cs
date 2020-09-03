using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public int NumberOfPages { get; set; }
        public Genre Genre { get; set; }
    }

    enum Genre
    {
        Drama,
        Fantasy,
        Nonfiction,
        Scifi,
        Action,
        Romance,
        Mystery,
        Horror
    }
}
