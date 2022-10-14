using BookShop.src.Application.Categories.Commands.CreateCategory;
using FluentValidation;
//using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Code.Application.Categories.Commands.CreateCategory;
public class CreateCategoryCommandValidator : AbstractValidator<CreateCategoryCommand>
{
    private readonly ICategoryRepository _repository;
    private readonly IApplicationDbContext _context;
    public CreateCategoryCommandValidator(ICategoryRepository repository, IApplicationDbContext context)
    {
        this._repository = repository;
        this._context = context;

        RuleFor(v => v.Name)
            .NotEmpty().WithMessage("Category Name is requried")
            .MaximumLength(200).WithMessage("Category Name must not exceed 200 characters")
            .Must(BeUniqeName).WithMessage("The specified Category Name already exists");
    }

    public bool BeUniqeName(string categoryName)
    {
        return _context.Categories.All(x => x.Name != categoryName);
    }
}