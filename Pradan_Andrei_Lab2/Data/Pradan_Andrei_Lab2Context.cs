using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pradan_Andrei_Lab2.Models;

    public class Pradan_Andrei_Lab2Context : DbContext
    {
        public Pradan_Andrei_Lab2Context (DbContextOptions<Pradan_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Pradan_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Pradan_Andrei_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Pradan_Andrei_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Pradan_Andrei_Lab2.Models.Category>? Category { get; set; }

        public DbSet<Pradan_Andrei_Lab2.Models.Member>? Member { get; set; }

        public DbSet<Pradan_Andrei_Lab2.Models.Borrowing>? Borrowing { get; set; }
    }
