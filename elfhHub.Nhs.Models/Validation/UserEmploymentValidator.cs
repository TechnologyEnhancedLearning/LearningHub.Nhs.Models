namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Entities;
    using FluentValidation;

    /// <summary>
    /// The user employment validator.
    /// </summary>
    public class UserEmploymentValidator : AbstractValidator<UserEmployment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserEmploymentValidator"/> class.
        /// </summary>
        public UserEmploymentValidator()
        {
            this.RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("UserId is a required field");

            this.RuleFor(x => x.LocationId)
                .GreaterThan(0)
                .WithMessage("LocationId is a required field");
        }
    }
}
