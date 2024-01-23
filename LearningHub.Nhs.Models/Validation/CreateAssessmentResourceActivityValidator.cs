// <copyright file="CreateAssessmentResourceActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create assessment resource activity" validator.
    /// </summary>
    public class CreateAssessmentResourceActivityValidator : AbstractValidator<CreateAssessmentResourceActivityViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssessmentResourceActivityValidator"/> class.
        /// </summary>
        public CreateAssessmentResourceActivityValidator()
        {
            this.RuleFor(x => x.ResourceActivityId)
                .NotEqual(0)
                .WithMessage("ResourceActivity is mandatory.");
        }
    }
}
