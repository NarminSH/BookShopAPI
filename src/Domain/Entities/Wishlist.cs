using System;
namespace Domain.Entities
{
    public class Wishlist: BaseAuditibleEntity
    {
        public ICollection<WishlistItem> WishlistItems { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

