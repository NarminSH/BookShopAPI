using System;
using Application.Dtos.LanguageDtos;
using Application.Dtos.UserDtos;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Application.Users.Queries.GetUsers;

public record GetUsersQuery : IRequest<IEnumerable<GetUserDto>>;

public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, IEnumerable<GetUserDto>>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;

    public GetUsersQueryHandler(UserManager<AppUser> userManager, IMapper mapper)
    {
        this._userManager = userManager;
        this._mapper = mapper;
    }

    public async Task<IEnumerable<GetUserDto>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
    {
        var users = await _userManager.Users.ToListAsync();

        var usersDto = _mapper.Map<IEnumerable<GetUserDto>>(users);
        return usersDto;
    }
}