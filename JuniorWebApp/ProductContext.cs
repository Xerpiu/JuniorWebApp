using Microsoft.EntityFrameworkCore;
using JuniorWebApp.Models;
using System;

namespace JuniorWebApp
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product() { Id = Guid.Parse("2ED3F6BA-FD71-433B-867C-3FA3A7BCC736"), Name = "Laptop MSI Alpha 15 (A3DD-032XPL)", Price = 4299.00m },
                new Product() { Id = Guid.Parse("3AAFDC0A-F34F-44ED-954B-A15A26B111C9"), Name = "Laptop Acer Nitro 5 (NH.Q5XEP.003)", Price = 2999.00m },
                new Product() { Id = Guid.Parse("966E64C2-879C-43C4-9586-B043064FB86A"), Name = "Klawiatura HYKKER dla graczy", Price = 52.00m },
                new Product() { Id = Guid.Parse("5C14ADDD-5DD8-45D7-B1E3-B0EB0E146518"), Name = "Laptop ASUS VivoBook E203MA N4000 4GB 64GB eMMC W10S", Price = 1099.43m },
                new Product() { Id = Guid.Parse("50921C24-8CB2-4D8F-84AF-B48A32B95517"), Name = "Laptop ASUS VivoBook 15 (R512UB-EJ114) 4417U 4GB 256GB SSD GF-MX110 W10", Price = 2099.99m },
                new Product() { Id = Guid.Parse("D4A8BE32-D25B-4A13-B138-BAA6AA80371B"), Name = "Monitor IIYAMA G-MASTER G2530HSU-B1", Price = 599.00m },
                new Product() { Id = Guid.Parse("7C9E6679-7425-40DE-944B-E07FC1F90AE7"), Name = "Mysz Sharkoon Skiller SGM2", Price = 97.01m },
                new Product() { Id = Guid.Parse("C1820AB0-0E63-4DD7-8A32-EFF5F7628F92"), Name = "Smartfon SAMSUNG Galaxy S10e, 128 GB, Dual SIM", Price = 2339.00m },
                new Product() { Id = Guid.Parse("178F9C73-6612-49C3-95ED-F088EE325DE3"), Name = "Smartfon XIAOMI Redmi Note 5, 64 GB, Dual SIM", Price = 622.00m }
            );
        }
    }
}
