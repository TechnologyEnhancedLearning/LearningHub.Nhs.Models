// <copyright file="ResourceVersionKeywordValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The resource version keyword validator.
    /// </summary>
    public class ResourceVersionKeywordValidator : AbstractValidator<Entities.Resource.ResourceVersionKeyword>
    {
        /// <summary>
        /// The keyword max length.
        /// </summary>
        public const int KeywordMaxLength = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionKeywordValidator"/> class.
        /// </summary>
        public ResourceVersionKeywordValidator()
        {
            this.RuleFor(x => x.Keyword)
            .NotEmpty()
            .WithMessage("Keyword is mandatory.")
            .MaximumLength(KeywordMaxLength)
            .WithMessage(string.Format("Keyword cannot exceed {0} characters.", KeywordMaxLength));
        }
    }
}
