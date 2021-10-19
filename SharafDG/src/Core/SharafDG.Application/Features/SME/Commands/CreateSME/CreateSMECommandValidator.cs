using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.Features.SME.Commands.CreateSME
{
   public class CreateSMECommandValidator : AbstractValidator<CreateSMECommand>
    {
        public CreateSMECommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(40).WithMessage("{PropertyName} must not exceed 40 characters.");
            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
