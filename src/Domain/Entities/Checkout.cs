using System;
namespace Domain.Entities
{
    public class Checkout: BaseAuditibleEntity
    {
        public string ContactPhone { get; set; }
        public string Method { get; set; }
        public string? UserId { get; set; }
        public decimal Subtotal { get; set; }
        //todo add many to many with book and order
        public AppUser User { get; set; }
        public ShippingAddress shippingAddress { get; set; }
}
}

