using System;
using Application.Dtos.UserDtos;

namespace Application.Dtos.ShippingAddressDtos
{
    public class GetShippingAddressDto: BaseAuditibleDto, IMapFrom<ShippingAddress>
    {
        public string? UserId { get; set; }
        public GetUserDto User { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string DetailedAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}

