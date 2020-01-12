using System.ComponentModel.DataAnnotations;

namespace JuniorWebApp.Models
{
    public class ProductCreateRequestDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]    
        public decimal Price { get; set; }
    }
}
