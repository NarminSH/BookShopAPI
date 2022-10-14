using System;
using Application.Dtos.ShippingAddressDtos;
using Application.Dtos.UserDtos;

namespace Application.Dtos.CheckoutDtos
{
    public class GetCheckoutDto: BaseAuditibleDto, IMapFrom<Checkout>
    {
        public string ContactPhone { get; set; }
        public string Method { get; set; }
        public string? UserId { get; set; }
        public decimal Subtotal { get; set; }
        public GetUserDto User { get; set; }
        public GetShippingAddressDto shippingAddress { get; set; }
    }
}

