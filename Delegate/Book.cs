﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public Book(string title , string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
    }
}
