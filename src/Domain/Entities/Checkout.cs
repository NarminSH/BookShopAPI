using System;
namespace Domain.Entities
{
    public class Checkout: BaseAuditibleEntity
    {
        public string ContactPhone { get; set; }
        public string Method { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ShippingAddress shippingAddress { get; set; }
}
}

