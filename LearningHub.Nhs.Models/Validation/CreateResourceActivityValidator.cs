// <copyright file="CreateResourceActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create resource activity" validator.
    /// </summary>
    public class CreateResourceActivityValidator : AbstractValidator<CreateResourceActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateResourceActivityValidator"/> class.
        /// </summary>
        public CreateResourceActivityValidator()
        {
            this.RuleFor(x => x.ResourceVersionId)
                .NotEqual(0)
                .WithMessage("ResourceVersionId is mandatory.");

            this.RuleFor(x => x.ActivityStart)
                .LessThanOrEqualTo(x => x.ActivityEnd)
                .When(x => x.ActivityStart.HasValue)
                .When(x => x.ActivityEnd.HasValue)
                .WithMessage("Activity Start cannot be after the Activity End.");
        }
    }
}
