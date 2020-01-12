using Microsoft.EntityFrameworkCore;
using JuniorWebApp.Models;

namespace JuniorWebApp
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
    }
}
