// <copyright file="ResourceVersionFlagValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The resource version flag validator.
    /// </summary>
    public class ResourceVersionFlagValidator : AbstractValidator<Entities.Resource.ResourceVersionFlag>
    {
        /// <summary>
        /// The details max length.
        /// </summary>
        public const int DetailsMaxLength = 1024;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionFlagValidator"/> class.
        /// </summary>
        public ResourceVersionFlagValidator()
        {
            this.RuleFor(x => x.Details)
            .NotEmpty()
            .WithMessage("Details is mandatory.")
            .MaximumLength(DetailsMaxLength)
            .WithMessage(string.Format("Details cannot exceed {0} characters.", DetailsMaxLength));
        }
    }
}
