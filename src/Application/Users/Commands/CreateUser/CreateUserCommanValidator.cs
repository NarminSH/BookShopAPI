using System;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    private readonly UserManager<AppUser> _userManager;
    public CreateUserCommandValidator(UserManager<AppUser> userManager)
    {
        this._userManager = userManager;

        RuleFor(v => v.Email).NotEmpty().WithMessage("Email is required");
        //MustAsync(BeUniqueEmail).WithMessage("This email already exists");

        RuleFor(v => v.Username).NotEmpty().WithMessage("Username is required").
            MaximumLength(50).WithMessage("Username must not exceed 50 characters");
        //MustAsync(BeUniqueUsername).WithMessage("This username already exists");
    }
           

    //public async Task<bool> BeUniqueEmail(string email, CancellationToken cancellationToken)
    //{
    //    AppUser user =  await _userManager.FindByEmailAsync(email);
    //    if (user != null) return false;
    //    else return true;

    //}
    //public async Task<bool> BeUniqueUsername(string username, CancellationToken cancellationToken)
    //{
    //    AppUser user = await _userManager.FindByNameAsync(username);
    //    if (user != null) return false;
    //    else return true;
    //}

}



