using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lesan_Maria_Lab8.Models;

namespace Lesan_Maria_Lab8.Data
{
    public class Lesan_Maria_Lab8Context : DbContext
    {
        public Lesan_Maria_Lab8Context (DbContextOptions<Lesan_Maria_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Lesan_Maria_Lab8.Models.Book> Book { get; set; }

        public DbSet<Lesan_Maria_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Lesan_Maria_Lab8.Models.Category> Category { get; set; }
    }
}
