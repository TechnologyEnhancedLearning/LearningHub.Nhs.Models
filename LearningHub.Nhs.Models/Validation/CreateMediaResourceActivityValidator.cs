// <copyright file="CreateMediaResourceActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System;

    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create media resource activity" validator.
    /// </summary>
    public class CreateMediaResourceActivityValidator : AbstractValidator<CreateMediaResourceActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMediaResourceActivityValidator"/> class.
        /// </summary>
        public CreateMediaResourceActivityValidator()
        {
            this.RuleFor(x => x.ResourceActivityId)
                .NotEqual(0)
                .WithMessage("ResourceActivity is mandatory.");

            this.RuleFor(x => x.ActivityStart)
                .NotNull()
                .NotEqual(DateTimeOffset.MinValue)
                .WithMessage("ActivityStart is mandatory.");
        }
    }
}
