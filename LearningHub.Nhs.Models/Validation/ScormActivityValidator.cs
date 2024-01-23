// <copyright file="ScormActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create scorm activity" validator.
    /// </summary>
    public class ScormActivityValidator : AbstractValidator<ScormActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScormActivityValidator"/> class.
        /// </summary>
        public ScormActivityValidator()
        {
            this.RuleFor(x => x.InstanceId)
                .NotEqual(0)
                .WithMessage("InstanceId is mandatory.");
        }
    }
}
