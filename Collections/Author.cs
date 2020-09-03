﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }
        public Author(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
