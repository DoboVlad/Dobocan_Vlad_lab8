using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobocan_Vlad_lab8.Models;

namespace Dobocan_Vlad_lab8.Data
{
    public class Dobocan_Vlad_lab8Context : DbContext
    {
        public Dobocan_Vlad_lab8Context (DbContextOptions<Dobocan_Vlad_lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Dobocan_Vlad_lab8.Models.Book> Book { get; set; }

        public DbSet<Dobocan_Vlad_lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Dobocan_Vlad_lab8.Models.Category> Category { get; set; }
    }
}
