using System;
using Application.Dtos.BookDtos;
using Application.Dtos.CartDtos;
using Application.Dtos.UserDtos;
using Domain.Common;

namespace Application.Dtos.CartItemDtos
{
    public class GetCartItemDto : BaseAuditibleDto, IMapFrom<CartItem>
    {
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int BookId { get; set; }
        public GetBookDto Book { get; set; }
        public int UserId { get; set; }
        public GetUserDto User { get; set; }
        public int CartId { get; set; }
        public GetCartDto? Cart { get; set; }
    }
}