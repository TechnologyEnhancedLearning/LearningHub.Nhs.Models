namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The resource azure media asset validator.
    /// </summary>
    public class ResourceAzureMediaAssetValidator : AbstractValidator<Entities.Resource.ResourceAzureMediaAsset>
    {
         /// <summary>
        /// The file name max length.
        /// </summary>
        public const int FileNameLength = 1024;

        /// <summary>
        /// The file path max length.
        /// </summary>
        public const int FilePathLength = 1024;

        /// <summary>
        /// The locator uri information max length.
        /// </summary>
        public const int LocatorUriLength = 1024;

        /// <summary>
        /// The encode job name max length.
        /// </summary>
        public const int EncodeJobNameLength = 128;

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAzureMediaAssetValidator"/> class.
        /// </summary>
        public ResourceAzureMediaAssetValidator()
        {
            this.RuleFor(x => x.FilePath)
            .NotEmpty()
            .WithMessage("File path is mandatory.")
            .MaximumLength(FilePathLength)
            .WithMessage($"File path cannot exceed {FilePathLength} characters.");

            this.RuleFor(x => x.LocatorUri)
            .NotEmpty()
            .WithMessage("Locator Uri is mandatory.")
            .MaximumLength(LocatorUriLength)
            .WithMessage($"Locator Uri cannot exceed {LocatorUriLength} characters.");

            this.RuleFor(x => x.EncodeJobName)
            .NotEmpty()
            .WithMessage("Encode job name is mandatory.")
            .MaximumLength(EncodeJobNameLength)
            .WithMessage($"Encode job name cannot exceed {EncodeJobNameLength} characters.");

            this.RuleFor(x => x.EncodeJobName)
           .NotEmpty()
           .WithMessage("Encode job name is mandatory.")
           .MaximumLength(EncodeJobNameLength)
           .WithMessage($"Encode job name cannot exceed {EncodeJobNameLength} characters.");
        }
    }
}
