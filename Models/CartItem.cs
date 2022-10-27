using System.Collections.Generic;

namespace NotUseAuto.Models
{
    
    public class CartItem
    {
        public int Id { get; set; } 
        public int quantity { set; get; }
        public Product product { set; get; }
    }
}
