namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Common;
    using FluentValidation;

    /// <summary>
    /// The registration validator.
    /// </summary>
    public class RegistrationValidator : AbstractValidator<RegistrationRequestViewModel>
    {
        /// <summary>
        /// The email address length.
        /// </summary>
        public const int EmailAddressLength = 100;

        /// <summary>
        /// The first name length.
        /// </summary>
        public const int FirstNameLength = 50;

        /// <summary>
        /// The last name length.
        /// </summary>
        public const int LastNameLength = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="RegistrationValidator"/> class.
        /// </summary>
        public RegistrationValidator()
        {
            this.RuleFor(x => x.EmailAddress)
                .NotEmpty()
                .WithMessage("Email address is mandatory.")
                .MaximumLength(EmailAddressLength)
                .WithMessage(string.Format("Email address length cannot exceed {0} characters.", EmailAddressLength));

            this.RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("First name is mandatory.")
                .MaximumLength(FirstNameLength)
                .WithMessage(string.Format("First name length cannot exceed {0} characters.", FirstNameLength));

            this.RuleFor(x => x.LastName)
                .NotEmpty()
                .WithMessage("Last name is mandatory.")
                .MaximumLength(LastNameLength)
                .WithMessage(string.Format("Last name length cannot exceed {0} characters.", LastNameLength));

            this.RuleFor(x => x.CountryId)
                .GreaterThan(0)
                .WithMessage("Country is a required field");

            this.RuleFor(x => x.RegionId)
                .Must((o, context) =>
                {
                    return !(o.CountryId == 1 && o.RegionId == 0);
                })
                .WithMessage("Region is a required field for England");

            this.RuleFor(x => x.JobRoleId)
                .GreaterThan(0)
                .WithMessage("Job role is a required field");

            this.RuleFor(x => x.SpecialtyId)
                .GreaterThan(0)
                .WithMessage("Specialty is a required field")
                .When(x => x.UserRegistrationType == Enums.UserRegistrationTypeEnum.FullAccess);

            this.RuleFor(x => x.LocationId)
                .GreaterThan(0)
                .WithMessage("Place of work is a required field")
                .When(x => x.UserRegistrationType == Enums.UserRegistrationTypeEnum.FullAccess);

            this.RuleFor(x => x.GradeId)
                .GreaterThan(0)
                .WithMessage("Grade is a required field")
                .When(x => x.UserRegistrationType == Enums.UserRegistrationTypeEnum.FullAccess);
        }
    }
}
