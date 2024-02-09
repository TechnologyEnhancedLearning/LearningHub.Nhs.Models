namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The web link resource version validator.
    /// </summary>
    public class WebLinkResourceVersionValidator : AbstractValidator<Entities.Resource.WebLinkResourceVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebLinkResourceVersionValidator"/> class.
        /// </summary>
        public WebLinkResourceVersionValidator()
        {
            this.RuleFor(x => x.WebLinkUrl)
            .NotEmpty()
            .WithMessage("URL is mandatory.");
        }
    }
}
