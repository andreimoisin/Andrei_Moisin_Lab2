using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Moisin_Andrei_Lab2.Models;

namespace Moisin_Andrei_Lab2.Data
{
    public class Moisin_Andrei_Lab2Context : DbContext
    {
        public Moisin_Andrei_Lab2Context (DbContextOptions<Moisin_Andrei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Moisin_Andrei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Moisin_Andrei_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Moisin_Andrei_Lab2.Models.Author> Author { get; set; }

        public DbSet<Moisin_Andrei_Lab2.Models.Category> Category { get; set; }
    }
}
