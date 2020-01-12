using JuniorWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JuniorWebApp.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductContext _pContext;

        public ProductService(ProductContext pContext)
        {
            _pContext = pContext;
        }

        public Guid AddProduct(string name, decimal price)
        {
            var guid = Guid.NewGuid();

            Product product = new Product
            {
                Id = guid,
                Name = name,
                Price = price
            };

            _pContext.Products.Add(product);
            _pContext.SaveChanges();
            
            return guid;
        }

        public bool UpdateProduct(Guid id, string newName, decimal newPrice)
        {
            var product = GetProduct(id);
            var result = product != null;

            if(result)
            {
                product.Name = newName;
                product.Price = newPrice;

                _pContext.SaveChanges();
            }

            return result;
        }

        public Product GetProduct(Guid id)
        {
            if(id == null)
            {
                return null;
            }

            var product = _pContext.Products.FirstOrDefault(p => id == p.Id);

            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _pContext.Products;
        }

        public bool DeleteProduct(Guid id)
        {
            var product = _pContext.Products.FirstOrDefault(p => id == p.Id);
            var result = product != null;

            if(result)
            {
                _pContext.Products.Remove(product);
                _pContext.SaveChanges();
            }

            return result;
        }

        public bool HasProducts()
        {
            return _pContext.Products.Count() > 0;
        }
    }
}
