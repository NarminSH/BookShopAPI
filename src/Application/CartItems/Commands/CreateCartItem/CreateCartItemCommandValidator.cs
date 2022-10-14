using BookShop.src.Application.Categories.Commands.CreateCategory;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookShop.src.Application.CartItems.Commands.CreateCartItem;

public class CreateCartItemCommandValidator : AbstractValidator<CreateCartItemCommand>
{
    private readonly ICartItemRepository _repository;
    private readonly UserManager<AppUser> _userManager;

    public CreateCartItemCommandValidator(ICartItemRepository repository, UserManager<AppUser> userManager)
    {
        this._repository = repository;
        this._userManager = userManager;

        RuleFor(b => b.UserId).NotEmpty().WithMessage("User id can not be null")
            .Must(IfUserExistsInDb).WithMessage("User does not exist");
    }


    private bool IfUserExistsInDb(string id)
    {
        var user = _userManager.Users.Where(u => u.Id == id).First();
        if (user != null) return true;
        else return false;

    }
}