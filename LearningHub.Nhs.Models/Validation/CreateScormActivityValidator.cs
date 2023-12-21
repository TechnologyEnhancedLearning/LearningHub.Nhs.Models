// <copyright file="CreateScormActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create scorm activity" validator.
    /// </summary>
    public class CreateScormActivityValidator : AbstractValidator<CreateScormActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateScormActivityValidator"/> class.
        /// </summary>
        public CreateScormActivityValidator()
        {
            this.RuleFor(x => x.ResourceReferenceId)
                .NotEqual(0)
                .WithMessage("ResourceVersionId is mandatory.");
        }
    }
}
