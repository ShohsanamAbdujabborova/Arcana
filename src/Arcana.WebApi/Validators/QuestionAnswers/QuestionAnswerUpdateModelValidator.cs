﻿using Arcana.WebApi.Models.QuestionAnswers;
using Arcana.WebApi.Models.UserRoles;
using FluentValidation;

namespace Arcana.WebApi.Validators.QuestionAnswers;
public class QuestionAnswerUpdateModelValidator : AbstractValidator<QuestionAnswerUpdateModel>
{
    public QuestionAnswerUpdateModelValidator()
    {
        RuleFor(questionAnswer=>questionAnswer.Content)
            .NotNull()
            .WithMessage(questionAnswer=> $"{nameof(questionAnswer.Content)} is not specified");
    }
}