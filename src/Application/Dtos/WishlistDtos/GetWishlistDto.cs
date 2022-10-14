using System;
using Application.Dtos.UserDtos;
using Application.Dtos.WishlistItemDtos;

namespace Application.Dtos.WishlistDto
{
    public class GetWishlistDto
    {
        public ICollection<GetWishlistItemDto> WishlistItems { get; set; }
        public string? UserId { get; set; }
        public GetUserDto User { get; set; }
    }
}

