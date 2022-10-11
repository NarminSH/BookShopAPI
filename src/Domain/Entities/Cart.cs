using System;
namespace Domain.Entities
{
    public class Cart: BaseAuditibleEntity
    {
        public decimal Subtotal { get; set; }
        public ICollection<CartItem> cartItems { get; set; }
    }
}

