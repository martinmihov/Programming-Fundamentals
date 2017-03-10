﻿using System;
namespace _09_Book_Library
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
}
