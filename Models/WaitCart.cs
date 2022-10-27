using System.Collections.Generic;

namespace NotUseAuto.Models
{
    public class WaitCart
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ICollection<CartItem> cartItems { get; set; }

    }
}
