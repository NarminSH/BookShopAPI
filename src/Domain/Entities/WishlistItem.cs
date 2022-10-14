using System;
namespace Domain.Entities
{
    public class WishlistItem: BaseAuditibleEntity
    {
        public string ImageUrl { get; set; }
        public string BookTitle { get; set; }
        public decimal Price { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}


