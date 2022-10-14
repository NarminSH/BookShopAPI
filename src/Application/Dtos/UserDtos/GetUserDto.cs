using System;

namespace Application.Dtos.UserDtos
{
    public class GetUserDto: IMapFrom<AppUser>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string? Username { get; set; }
    }
}

