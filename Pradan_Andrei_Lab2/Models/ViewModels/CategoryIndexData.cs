﻿using System;
namespace Pradan_Andrei_Lab2.Models.ViewModels
{
	public class CategoryIndexData
	{
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
