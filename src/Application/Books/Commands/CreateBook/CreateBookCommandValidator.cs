using BookShop.src.Application.Categories.Commands.CreateCategory;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookShop.src.Application.Books.Commands.CreateBook;
public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    private readonly IBookRepository _repository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly UserManager<AppUser> _userManager;

    public CreateBookCommandValidator(IBookRepository repository, UserManager<AppUser> userManager,
        ICategoryRepository categoryRepository)
    {
        this._repository = repository;
        this._userManager = userManager;
        this._categoryRepository = categoryRepository;

        RuleFor(b => b.UserId).NotEmpty().WithMessage("User id can not be null")
            .Must(IfUserExistsInDb).WithMessage("User does not exist");

        RuleFor(c => c.CategoryId)
            .Must(IfCategoryExistsInDb).WithMessage("No category with given Id");
    }

    private bool IfUserExistsInDb(string id)
    {
        var user = _userManager.Users.Where(u => u.Id == id);
        if (user != null) return false;
        else return true;

    }
    private bool IfCategoryExistsInDb(int id)
    {
        var cat = _categoryRepository.GetById(id);
        if (cat != null) return false;
        else return true;
    }
}