using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public ICollection<Review>? Reviews { get; set; }
        public Cart? Carts { get; set; }
        //todo add one to one relation to user cart
        //public ICollection<CartItem>? CartItems { get; set; }
        public Wishlist? Wishlists { get; set; }
        //todo add one to one relation to user wishlist
        //public ICollection<WishlistItem>? WishlistItems { get; set; }
        public ICollection<Book>? Books { get; set; }
        public ICollection<ShippingAddress>? ShippingAddresses { get; set; }

    }
}