using System;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User : IdentityUser
    {

        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Cart>? Carts { get; set; }
        public ICollection<CartItem>? CartItems { get; set; }
        public ICollection<Wishlist>? Wishlists { get; set; }
        public ICollection<WishlistItem>? WishlistItems { get; set; }
        public ICollection<Book>? Books { get; set; }
        public ICollection<ShippingAddress>? ShippingAddresses { get; set; }

    }
}

