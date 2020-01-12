using System;
using System.ComponentModel.DataAnnotations;

namespace JuniorWebApp.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
