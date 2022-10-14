using System;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories.Abstraction
{
    public interface IApplicationDbContext
    {
         DbSet<Category> Categories { get; set; }
         DbSet<Book> Books { get; set; }
         DbSet<BookFormats> bookFormats { get; set; }
         DbSet<BookLanguages> bookLanguages { get; set; }
         DbSet<BookGenres> bookGenres { get; set; }
         DbSet<Genre> Genres { get; set; }
         DbSet<CartItem> CartItems { get; set; }
         DbSet<Cart> Carts { get; set; }
         DbSet<Language> Languages { get; set; }
         DbSet<Image> Images { get; set; }
         DbSet<Review> Reviews { get; set; }
         DbSet<ShippingAddress> ShippingAddresses { get; set; }
         DbSet<WishlistItem> WishlistItems { get; set; }
         DbSet<Wishlist> Wishlists { get; set; }
         DbSet<Checkout> Checkouts { get; set; }
    }
}

