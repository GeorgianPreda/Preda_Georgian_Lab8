#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Preda_Georgian_Lab8.Models;

namespace Preda_Georgian_Lab8.Data
{
    public class Preda_Georgian_Lab8Context : DbContext
    {
        public Preda_Georgian_Lab8Context (DbContextOptions<Preda_Georgian_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Preda_Georgian_Lab8.Models.Book> Book { get; set; }

        public DbSet<Preda_Georgian_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Preda_Georgian_Lab8.Models.Category> Category { get; set; }
    }
}
