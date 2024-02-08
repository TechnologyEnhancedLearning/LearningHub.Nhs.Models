namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.OpenAthens;

    /// <summary>
    /// The create linked open athens user validator.
    /// </summary>
    public class CreateLinkedOpenAthensUserValidator : AbstractValidator<CreateOpenAthensLinkToLhUser>
    {
        /// <summary>
        /// The email address length.
        /// </summary>
        public const int EmailAddressLength = 100;

        /// <summary>
        /// The last name length.
        /// </summary>
        public const int LastNameLength = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLinkedOpenAthensUserValidator"/> class.
        /// </summary>
        public CreateLinkedOpenAthensUserValidator()
        {
            this.RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("Email address is mandatory.")
                .MaximumLength(EmailAddressLength)
                .WithMessage(string.Format("Email address length cannot exceed {0} characters.", EmailAddressLength));

            this.RuleFor(x => x.VerifyEmail)
                .NotEmpty()
                .WithMessage("VerifyEmail is mandatory.")
                .MaximumLength(EmailAddressLength)
                .WithMessage(string.Format("VerifyEmail length cannot exceed {0} characters.", EmailAddressLength));

            this.RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is mandatory.")
                .MaximumLength(LastNameLength)
                .WithMessage(string.Format("Last name length cannot exceed {0} characters.", LastNameLength));
        }
    }
}
