using Arcana.WebApi.Models.Languages;
using FluentValidation;

namespace Arcana.WebApi.Validators.Languages;

public class LanguageCreateModelValidator : AbstractValidator<LanguageCreateModel>
{
    public LanguageCreateModelValidator()
    {
        RuleFor(language => language.Name)
            .NotNull()
            .WithMessage(language => $"{nameof(language.Name)} is not specified");
        RuleFor(language => language.ShortName)
            .NotNull()
            .WithMessage(language => $"{nameof(language.ShortName)} is not specified");
    }
}