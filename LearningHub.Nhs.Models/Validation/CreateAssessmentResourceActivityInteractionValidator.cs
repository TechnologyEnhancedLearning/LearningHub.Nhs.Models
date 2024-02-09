namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The "create assessment resource activity interaction" validator.
    /// </summary>
    public class CreateAssessmentResourceActivityInteractionValidator : AbstractValidator<CreateAssessmentResourceActivityInteractionViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAssessmentResourceActivityInteractionValidator"/> class.
        /// </summary>
        public CreateAssessmentResourceActivityInteractionValidator()
        {
            this.RuleFor(x => x.AssessmentResourceActivityId)
                .NotEqual(0)
                .WithMessage("MediaResourceActivity is mandatory.");

            this.RuleFor(x => x.QuestionNumber)
             .NotNull()
             .WithMessage("QuestionNumber is mandatory.");
        }
    }
}
