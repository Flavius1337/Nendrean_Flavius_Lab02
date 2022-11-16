using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nendrean_Flavius_Lab02.Models;

namespace Nendrean_Flavius_Lab02.Data
{
    public class Nendrean_Flavius_Lab02Context : DbContext
    {
        public Nendrean_Flavius_Lab02Context (DbContextOptions<Nendrean_Flavius_Lab02Context> options)
            : base(options)
        {
        }

        public DbSet<Nendrean_Flavius_Lab02.Models.Book> Book { get; set; } = default!;

        public DbSet<Nendrean_Flavius_Lab02.Models.Publisher> Publisher { get; set; }

        public DbSet<Nendrean_Flavius_Lab02.Models.Author> Author { get; set; }
    }
}
