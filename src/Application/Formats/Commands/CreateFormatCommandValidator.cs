using System;
using Application.Formats.Commands;
using FluentValidation;

namespace Application.Formats.Commands;

public class CreateFormatCommandValidator : AbstractValidator<CreateFormatCommand>
{
    private readonly IFormatRepository _repository;

    public CreateFormatCommandValidator(IFormatRepository repository)
    {
        this._repository = repository;

        RuleFor(b => b.Name).NotEmpty().WithMessage("Enter Format")
            .MinimumLength(2).WithMessage("Must be more than 2 characters");
    }
}
