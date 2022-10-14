using System;
using Application.Dtos.CategoryDtos;
using Application.Dtos.UserDtos;

namespace Application.Dtos.BookDtos
{
    public class GetBookDto : BaseAuditibleDto, IMapFrom<Book>
    {
        public string Title { get; set; } 
        public string Description { get; set; } 
        public string Author { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Quantity { get; set; }
        //public ICollection<Review> Reviews { get; set; }
        //public ICollection<Image> Images { get; set; }
        //public ICollection<BookLanguages> BookLanguages { get; set; }
        //public ICollection<BookFormats> BookFormats { get; set; }
        //public ICollection<BookGenres> BookGenres { get; set; }
        public string? UserId { get; set; }
        public GetUserDto? Vendor { get; set; } 
        public double Rate { get; set; }
        public int CategoryId { get; set; }
        public GetCategoryDto? Category { get; set; }

    }
}

