﻿using System;
namespace Pradan_Andrei_Lab2.Models
{
	public class BookData
	{
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}

