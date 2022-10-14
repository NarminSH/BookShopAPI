using System;
namespace Domain.Entities
{
    public class Cart: BaseAuditibleEntity
    {
        public decimal Subtotal { get; set; }
        public ICollection<CartItem> cartItems { get; set; }
        public string? UserId { get; set; }
        public AppUser User { get; set; }
    }
}

