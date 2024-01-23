// <copyright file="UserValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Common;
    using FluentValidation;

    /// <summary>
    /// The user validator.
    /// </summary>
    public class UserValidator : AbstractValidator<UserAdminDetailViewModel>
    {
        /// <summary>
        /// The First Name max length.
        /// </summary>
        public const int FirstNameMaxLength = 50;

        /// <summary>
        /// The Last Name max length.
        /// </summary>
        public const int LastNameMaxLength = 50;

        /// <summary>
        /// The Email Address max length.
        /// </summary>
        public const int EmailAddressMaxLength = 100;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserValidator"/> class.
        /// </summary>
        public UserValidator()
        {
            this.RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is mandatory.")
                .MaximumLength(FirstNameMaxLength)
                .WithMessage($"First name cannot exceed {FirstNameMaxLength} characters.");

            this.RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is mandatory.")
                .MaximumLength(LastNameMaxLength)
                .WithMessage($"Last name cannot exceed {LastNameMaxLength} characters.");

            this.RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("Email address is mandatory.")
                .MaximumLength(EmailAddressMaxLength)
                .WithMessage($"Email address cannot exceed {EmailAddressMaxLength} characters.")
                .Matches(@"(^$|^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$)")
                .WithMessage("The format of the email address is invalid.");

            this.RuleFor(x => x.AltEmailAddress)
               .MaximumLength(EmailAddressMaxLength)
               .WithMessage($"Email address cannot exceed {EmailAddressMaxLength} characters.")
               .Matches(@"(^$|^(([^<>()[\]\\.,;:\s@""]+(\.[^<>()[\]\\.,;:\s@""]+)*)|("".+""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$)")
               .WithMessage("The format of the email address is invalid.");

            this.RuleFor(x => x.FailedLoginCount)
                .NotNull()
                .WithMessage("Failed login count is mandatory.")
                .GreaterThan(-1)
                .WithMessage("Failed login count must be 0 or greater.");
        }
    }
}
