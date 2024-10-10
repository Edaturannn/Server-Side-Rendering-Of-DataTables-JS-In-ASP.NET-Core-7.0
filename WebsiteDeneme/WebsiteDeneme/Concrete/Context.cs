using System;
using Microsoft.EntityFrameworkCore;
using WebsiteDeneme.Entity;

namespace WebsiteDeneme.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ProductDatabase;User=sa;Password=123456aA*;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
