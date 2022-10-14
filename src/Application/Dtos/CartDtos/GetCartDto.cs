using System;
using Application.Dtos.CartItemDtos;
using Application.Dtos.UserDtos;

namespace Application.Dtos.CartDtos
{
    public class GetCartDto : BaseAuditibleDto, IMapFrom<Cart>
    {
        public decimal Subtotal { get; set; }
        public ICollection<GetCartItemDto> cartItems { get; set; }
        public string? UserId { get; set; }
        public GetUserDto? User { get; set; }
    }
}

