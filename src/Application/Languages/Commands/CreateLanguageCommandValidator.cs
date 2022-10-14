using System;
using Application.Languages.Commands;
using FluentValidation;
using Microsoft.AspNetCore.Identity;

namespace Application.Languages.Commands;

public class CreateLanguageCommandValidator : AbstractValidator<CreateLanguageCommand>
{
    private readonly ILanguageRepository _repository;

    public CreateLanguageCommandValidator(ILanguageRepository repository)
    {
        this._repository = repository;

        RuleFor(b => b.Name).NotEmpty().WithMessage("Enter Language")
            .MinimumLength(2).WithMessage("Language length must be more than 2")
            .MaximumLength(30).WithMessage("Maximum length can not be more than 30 characters");
    }
}
