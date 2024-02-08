namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The ExternalSystem validator.
    /// </summary>
    public class ExternalSystemValidator : AbstractValidator<Entities.External.ExternalSystem>
    {
        /// <summary>
        /// The title max length.
        /// </summary>
        public const int NameMaxLength = 100;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSystemValidator"/> class.
        /// </summary>
        public ExternalSystemValidator()
        {
            this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("Title cannot exceed {0} characters.", NameMaxLength));

            this.RuleFor(x => x.Code)
            .NotEmpty()
            .WithMessage("Code is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("Code cannot exceed {0} characters.", NameMaxLength));

            this.RuleFor(x => x.CallbackUrl)
            .NotEmpty()
            .WithMessage("CallbackUrl is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("CallbackUrl cannot exceed {0} characters.", NameMaxLength));

            this.RuleFor(x => x.SecretKey)
            .NotEmpty()
            .WithMessage("SecretKey is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("SecretKey cannot exceed {0} characters.", 512));

            this.RuleFor(x => x.TermsAndConditions)
            .NotEmpty()
            .WithMessage("TermsAndConditions is mandatory.");
        }
    }
}
