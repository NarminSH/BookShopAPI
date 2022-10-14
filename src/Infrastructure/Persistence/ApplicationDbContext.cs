using System;
using System.Reflection;
using System.Reflection.Emit;
using Code.Infrastructure.Persistence.Interceptors;
using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>, IApplicationDbContext
    {
        private readonly AuditableEntitySaveChangesInterceptor _auditableEntitySaveChangesInterceptor;
        public ApplicationDbContext(AuditableEntitySaveChangesInterceptor auditableEntitySaveChangesInterceptor,
            DbContextOptions<ApplicationDbContext> opt) : base(opt)
        {
            this._auditableEntitySaveChangesInterceptor = auditableEntitySaveChangesInterceptor;
        }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookFormats> bookFormats { get; set; }
        public virtual DbSet<BookLanguages> bookLanguages { get; set; }
        public virtual DbSet<BookGenres> bookGenres { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; }
        public virtual DbSet<WishlistItem> WishlistItems { get; set; }
        public virtual DbSet<Wishlist> Wishlists { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }
        DbSet<DiscountPrice> DiscountPrices { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.AddInterceptors(this._auditableEntitySaveChangesInterceptor);
            base.OnConfiguring(optionsBuilder);
        }

    }
   
}