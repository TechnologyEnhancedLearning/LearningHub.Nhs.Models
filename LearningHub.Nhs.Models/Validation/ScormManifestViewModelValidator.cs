// <copyright file="ScormManifestViewModelValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Collections.Generic;
    using FluentValidation;

    /// <summary>
    /// The scorm resource version manifest validator.
    /// </summary>
    public class ScormManifestViewModelValidator : AbstractValidator<Resource.ScormManifestViewModel>
    {
        /// <summary>
        /// The title max length.
        /// </summary>
        public const int TitleMaxLength = 255;

        /// <summary>
        /// The author max length.
        /// </summary>
        public const int AuthorMaxLength = 512;

        /// <summary>
        /// The duration max length.
        /// </summary>
        public const int DurationMaxLength = 128;

        /// <summary>
        /// The keywords max length.
        /// </summary>
        public const int KeywordsMaxLength = 1000;

        /// <summary>
        /// The manifest url max length.
        /// </summary>
        public const int ManifestURLMaxLength = 255;

        /// <summary>
        /// The quicklink id max length.
        /// </summary>
        public const int QuicklinkIdMaxLength = 30;

        /// <summary>
        /// The catalog entry max length.
        /// </summary>
        public const int CatalogEntryMaxLength = 128;

        /// <summary>
        /// The copyright max length.
        /// </summary>
        public const int CopyrightMaxLength = 30;

        /// <summary>
        /// The resource indentifier max length.
        /// </summary>
        public const int ResourceIdentifierMaxLength = 128;

        /// <summary>
        /// The item indentifier max length.
        /// </summary>
        public const int ItemIdentifierMaxLength = 128;

        /// <summary>
        /// The template version max length.
        /// </summary>
        public const int TemplateVersionMaxLength = 50;

        /// <summary>
        /// The launch data max length.
        /// </summary>
        public const int LaunchDataMaxLength = 4096;

        /// <summary>
        /// The comments from LMS max length.
        /// </summary>
        public const int CommentsFromLmsMaxLength = 4096;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScormManifestViewModelValidator"/> class.
        /// </summary>
        public ScormManifestViewModelValidator()
        {
            this.RuleFor(x => x.Title)
            .MaximumLength(TitleMaxLength)
            .WithMessage($"Title cannot exceed {TitleMaxLength} characters.");

            this.RuleFor(x => x.Author)
            .MaximumLength(AuthorMaxLength)
            .WithMessage($"Author cannot exceed {AuthorMaxLength} characters.");

            this.RuleFor(x => x.Duration)
            .MaximumLength(DurationMaxLength)
            .WithMessage($"Duration cannot exceed {DurationMaxLength} characters.");

            this.RuleFor(x => x.Keywords)
            .MaximumLength(KeywordsMaxLength)
            .WithMessage($"Keywords cannot exceed {KeywordsMaxLength} characters.");

            this.RuleFor(x => x.ManifestUrl)
            .MaximumLength(ManifestURLMaxLength)
            .WithMessage($"ManifestUrl cannot exceed {ManifestURLMaxLength} characters.");

            this.RuleFor(x => x.QuicklinkId)
            .MaximumLength(QuicklinkIdMaxLength)
            .WithMessage($"QuicklinkId cannot exceed {QuicklinkIdMaxLength} characters.");

            this.RuleFor(x => x.CatalogEntry)
            .MaximumLength(CatalogEntryMaxLength)
            .WithMessage($"CatalogEntry cannot exceed {CatalogEntryMaxLength} characters.");

            this.RuleFor(x => x.Copyright)
            .MaximumLength(CopyrightMaxLength)
            .WithMessage($"Copyright cannot exceed {CopyrightMaxLength} characters.");

            this.RuleFor(x => x.ResourceIdentifier)
            .MaximumLength(ResourceIdentifierMaxLength)
            .WithMessage($"ResourceIdentifier cannot exceed {ResourceIdentifierMaxLength} characters.");

            this.RuleFor(x => x.ItemIdentifier)
            .MaximumLength(ItemIdentifierMaxLength)
            .WithMessage($"ItemIdentifier cannot exceed {ItemIdentifierMaxLength} characters.");

            this.RuleFor(x => x.TemplateVersion)
            .MaximumLength(TemplateVersionMaxLength)
            .WithMessage($"TemplateVersion cannot exceed {TemplateVersionMaxLength} characters.");

            this.RuleFor(x => x.LaunchData)
            .MaximumLength(LaunchDataMaxLength)
            .WithMessage($"LaunchData cannot exceed {LaunchDataMaxLength} characters.");

            var validTimeLimitActions = new List<string>() { "exit,message", "exit,no message", "continue,message", "continue,no message" };
            this.RuleFor(x => x.TimeLimitAction)
              .Must(x => x == string.Empty || validTimeLimitActions.Contains(x))
              .WithMessage("If specified must be one of: " + string.Join(",", validTimeLimitActions));

            this.RuleFor(x => x.MaxTimeAllowed)
                .Matches(@"^((?:(\d?\d?\d\d):(\d\d):(\d\d))(\.\d?\d)?)?$")
                .WithMessage("If specified must be in format: (HH)HH:MM:SS(.SS)");
        }
    }
}
