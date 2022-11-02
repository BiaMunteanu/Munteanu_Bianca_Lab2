using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munteanu_Bianca_Lab2.Models;

namespace Munteanu_Bianca_Lab2.Data
{
    public class Munteanu_Bianca_Lab2Context : DbContext
    {
        public Munteanu_Bianca_Lab2Context (DbContextOptions<Munteanu_Bianca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Munteanu_Bianca_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Munteanu_Bianca_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Munteanu_Bianca_Lab2.Models.Author> Author { get; set; }

        public DbSet<Munteanu_Bianca_Lab2.Models.Category> Category { get; set; }
    }
}
