
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NotUseAuto.Models
{
    public class Product
    {
      
        // properties Id, Name, Price,Quantity,  Description
        public int Id { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Name must be 5 to 20 charecter"), MinLength(5)]
        public string Name { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Price must be 1 to 1000")]
        public decimal Price { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Quantity must be 1 to 100")]
        public int Quantity { get; set; }
        [Required]
        public string Description { get; set; }

        [Required]
        
        public string Image { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }






    }
}
