using ITProductsWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ITProductsWeb.Data
{
    public class ProductsDbContext:DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options): base(options)
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}
