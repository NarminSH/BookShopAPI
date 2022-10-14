using System;

namespace Domain.Entities
{
    public class Book : BaseAuditibleEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }
        public int? DiscountPriceId { get; set; }
        public DiscountPrice DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<BookLanguages>? BookLanguages { get; set; }
        public ICollection<BookFormats>? BookFormats { get; set; }
        public ICollection<BookGenres>? BookGenres { get; set; }
        public string? UserId { get; set; }
        public AppUser Vendor { get; set; } = null!;
        public double Rate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

