using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Administration.Model;

namespace Administration
{
    public class MyDBContext : DbContext
    {
        public DbSet<Product> Producten { get; set; }
        public DbSet<ProductCategorie> ProductCategorieen { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=localhost\\SQLEXPRESS;" +
                "Database=AdministrationEF;" +
                "Trusted_Connection=True;" +
                "MultipleActiveResultSets=True;" +
                "TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 
        }
    }
}
