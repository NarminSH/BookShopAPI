using System;
namespace Domain.Entities
{
    public class ShippingAddress: BaseAuditibleEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string DetailedAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        
    }
}

