﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ilisan_Iosif_Alexandru_Lab2.Models;

namespace Ilisan_Iosif_Alexandru_Lab2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext (DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Ilisan_Iosif_Alexandru_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Ilisan_Iosif_Alexandru_Lab2.Models.Customer> Customer { get; set; } = default!;
        public DbSet<Ilisan_Iosif_Alexandru_Lab2.Models.Genre> Genre { get; set; } = default!;

        public DbSet<Ilisan_Iosif_Alexandru_Lab2.Models.Author> Author{ get; set; } = default!;

        

    }
}

