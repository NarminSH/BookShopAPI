using System;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Application.Genres.Commands;


public class CreateGenreCommandValidator : AbstractValidator<CreateGenreCommand>
{
    private readonly IGenreRepository _repository;

    public CreateGenreCommandValidator(IGenreRepository repository)
    {
        this._repository = repository;

        RuleFor(b => b.Name).NotEmpty().WithMessage("Enter Genre")
            .MinimumLength(3).WithMessage("Must be more than 3 characters");
    }
}