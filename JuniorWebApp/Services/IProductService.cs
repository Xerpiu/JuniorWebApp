using System;
using System.Collections.Generic;
using JuniorWebApp.Models;

namespace JuniorWebApp.Services
{
    public interface IProductService
    {
        public Guid AddProduct(string name, decimal price);

        public bool UpdateProduct(Guid id, string newName, decimal newPrice);

        public bool HasProducts();

        public IEnumerable<Product> GetProducts();
        public Product GetProduct(Guid id);

        public bool DeleteProduct(Guid id);
    }
}
