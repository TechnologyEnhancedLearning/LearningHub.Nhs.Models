namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The "create resource activity" validator.
    /// </summary>
    public class ResourceVersionUserAcceptanceValidator : AbstractValidator<ResourceVersionUserAcceptance>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionUserAcceptanceValidator"/> class.
        /// </summary>
        public ResourceVersionUserAcceptanceValidator()
        {
            this.RuleFor(x => x.ResourceVersionId)
                .NotEqual(0)
                .WithMessage("ResourceVersionId is mandatory.");

            this.RuleFor(x => x.UserId)
                .NotEqual(0)
                .WithMessage("UserId is mandatory.");
        }
    }
}
