// <copyright file="LaunchScormActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "launch scorm activity" validator.
    /// </summary>
    public class LaunchScormActivityValidator : AbstractValidator<LaunchScormActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchScormActivityValidator"/> class.
        /// </summary>
        public LaunchScormActivityValidator()
        {
            this.RuleFor(x => x.ResourceReferenceId)
                .NotEqual(0)
                .WithMessage("ResourceReferenceId is mandatory.");
        }
    }
}
