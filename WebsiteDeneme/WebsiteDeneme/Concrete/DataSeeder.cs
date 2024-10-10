using System;
using WebsiteDeneme.Entity;

namespace WebsiteDeneme.Concrete
{
    public static class DataSeeder
    {
        public static void Seed(Context context)
        {
            context.Database.EnsureCreated();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(new List<Category>
            {
                new Category { Name = "Product 1", Price = 10.99M },
                new Category { Name = "Product 2", Price = 20.99M },
                new Category { Name = "Product 3", Price = 30.99M }
            });
                context.SaveChanges();
            }
        }
    }
}

