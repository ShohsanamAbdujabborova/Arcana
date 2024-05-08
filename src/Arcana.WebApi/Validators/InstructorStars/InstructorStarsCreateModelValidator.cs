using Arcana.WebApi.Models.InstructorStars;
using FluentValidation;

namespace Arcana.WebApi.Validators.InstructorStars;

public class InstructorStarsCreateModelValidator : AbstractValidator<InstructorStarsCreateModel>
{
    public InstructorStarsCreateModelValidator()
    {
        RuleFor(instructorStars => instructorStars.Stars)
            .NotNull()
            .WithMessage(instructorStars => $"{nameof(instructorStars.Stars)} is not specified");
        RuleFor(instructorStars => instructorStars.StudentId)
            .NotNull()
            .WithMessage(instructorStars => $"{nameof(instructorStars.StudentId)} is not specified");
        RuleFor(instructorStars => instructorStars.InstructorId)
            .NotNull()
            .WithMessage(instructorStars => $"{nameof(instructorStars.InstructorId)} is not specified");
    }
}