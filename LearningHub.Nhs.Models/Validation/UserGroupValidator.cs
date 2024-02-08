namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// The user group validator.
    /// </summary>
    public class UserGroupValidator : AbstractValidator<UserGroup>
    {
        /// <summary>
        /// The name max length.
        /// </summary>
        public const int NameMaxLength = 255;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroupValidator"/> class.
        /// </summary>
        public UserGroupValidator()
        {
            this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("Name length cannot exceed {0} characters.", NameMaxLength));
        }
    }
}
