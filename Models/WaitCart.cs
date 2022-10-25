using System.Collections.Generic;

namespace NotUseAuto.Models
{
    public class WaitCart
    {
        public int Id { get; set; }
        public List<CartItem> CartItem { get; set; }
    }
}
