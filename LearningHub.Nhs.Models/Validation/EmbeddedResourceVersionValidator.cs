namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The embedded resource version validator.
    /// </summary>
    public class EmbeddedResourceVersionValidator : AbstractValidator<Entities.Resource.EmbeddedResourceVersion>
    {
        /// <summary>
        /// The embed code max length.
        /// </summary>
        public const int EmbedCodeMaxLength = 255;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedResourceVersionValidator"/> class.
        /// </summary>
        public EmbeddedResourceVersionValidator()
        {
            this.RuleFor(x => x.EmbedCode)
            .NotEmpty()
            .WithMessage("Embed Code is mandatory.")
            .MaximumLength(EmbedCodeMaxLength)
            .WithMessage(string.Format("Embed Code cannot exceed {0} characters.", EmbedCodeMaxLength));
        }
    }
}
