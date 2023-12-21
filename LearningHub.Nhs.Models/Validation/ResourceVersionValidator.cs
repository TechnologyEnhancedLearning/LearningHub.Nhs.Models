// <copyright file="ResourceVersionValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Text.RegularExpressions;
    using FluentValidation;

    /// <summary>
    /// The resource version validator.
    /// </summary>
    public class ResourceVersionValidator : AbstractValidator<Entities.Resource.ResourceVersion>
    {
        /// <summary>
        /// The title max length.
        /// </summary>
        public const int TitleMaxLength = 255;

        /// <summary>
        /// The description max length.
        /// </summary>
        public const int DescriptionMaxLength = 8000;

        /// <summary>
        /// The max length for the description with html trimmed.
        /// </summary>
        public const int TrimmedDescriptionMaxLength = 4200;

        /// <summary>
        /// The additional information max length.
        /// </summary>
        public const int AdditionalInformationMaxLength = 250;

        /// <summary>
        /// The tag regex.
        /// </summary>
        public const string TagRegex = @"\<\/?\w{1,10}\/?\>";

        /// <summary>
        /// The entity regex.
        /// </summary>
        public const string EntityRegex = @"\&\#?[a-zA-Z0-9]+\;";

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionValidator"/> class.
        /// </summary>
        public ResourceVersionValidator()
        {
            this.RuleFor(x => x.Title)
            .MaximumLength(TitleMaxLength)
            .WithMessage($"Title cannot exceed {TitleMaxLength} characters.");

            this.RuleFor(x => x.Description)
            .MaximumLength(DescriptionMaxLength)
            .WithMessage($"Description cannot exceed {DescriptionMaxLength} characters.");

            this.RuleFor(x => x.Description)
                .Must(desc =>
                {
                    var tagRegex = new Regex(TagRegex);
                    var entityRegex = new Regex(EntityRegex);
                    desc = tagRegex.Replace(desc, string.Empty);
                    desc = entityRegex.Replace(desc, "F");
                    return desc.Length < TrimmedDescriptionMaxLength;
                }).WithMessage($"Trimmed description cannot exceed {TrimmedDescriptionMaxLength} characters.");

            this.RuleFor(x => x.AdditionalInformation)
            .MaximumLength(AdditionalInformationMaxLength)
            .WithMessage($"Additional Information cannot exceed {AdditionalInformationMaxLength} characters.");
        }
    }
}
