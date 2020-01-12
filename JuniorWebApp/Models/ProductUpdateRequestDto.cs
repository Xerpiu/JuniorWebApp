using System;
using System.ComponentModel.DataAnnotations;

namespace JuniorWebApp.Models
{
    public class ProductUpdateRequestDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
