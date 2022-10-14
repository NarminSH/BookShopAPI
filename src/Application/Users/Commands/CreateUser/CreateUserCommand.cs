using System;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Users.Commands.CreateUser;
public class CreateUserCommand : IRequest<IdentityResult>, IMapFrom<AppUser>
{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
}
public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, IdentityResult>
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;

    public CreateUserCommandHandler(UserManager<AppUser> userManager, IMapper mapper)
    {
        this._mapper = mapper;
        this._userManager = userManager;
    }
    public async Task<IdentityResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
      
        var entity = _mapper.Map<AppUser>(request);
        IdentityResult result = await _userManager.CreateAsync(entity);
        return result;

    }

}


