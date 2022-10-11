using System;

namespace Domain.Entities
{
    public class Book : BaseAuditibleEntity
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Quantity { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Image>? Images { get; set; }
        public ICollection<BookLanguages>? BookLanguages { get; set; }
        public ICollection<BookFormats>? BookFormats { get; set; }
        public ICollection<BookGenres>? BookGenres { get; set; }
        public int UserId { get; set; }
        public User Vendor { get; set; } = null!;
        public double Rate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}

