namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create media resource activity interaction" validator.
    /// </summary>
    public class CreateMediaResourceActivityInteractionValidator : AbstractValidator<CreateMediaResourceActivityInteractionViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateMediaResourceActivityInteractionValidator"/> class.
        /// </summary>
        public CreateMediaResourceActivityInteractionValidator()
        {
            this.RuleFor(x => x.MediaResourceActivityId)
                .NotEqual(0)
                .WithMessage("MediaResourceActivity is mandatory.");

            this.RuleFor(x => x.MediaResourceActivityType)
             .NotNull()
             .WithMessage("MediaResourceActivityType is mandatory.");
        }
    }
}
