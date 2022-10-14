using System;
namespace Domain.Entities
{
    public class Wishlist: BaseAuditibleEntity
    {
        public ICollection<WishlistItem> WishlistItems { get; set; }
        public string? UserId { get; set; }
        public AppUser User { get; set; }
    }
}

