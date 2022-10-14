using System;
using Application.Dtos.UserDtos;
using Application.Dtos.WishlistDto;

namespace Application.Dtos.WishlistItemDtos
{
    public class GetWishlistItemDto
    {
        public string ImageUrl { get; set; }
        public string BookTitle { get; set; }
        public decimal Price { get; set; }
        public string? UserId { get; set; }
        public GetUserDto User { get; set; }
        public int CartId { get; set; }
        public GetWishlistDto Wishlist { get; set; }
    }
}

