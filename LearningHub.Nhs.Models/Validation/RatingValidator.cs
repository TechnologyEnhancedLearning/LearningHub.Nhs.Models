namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Common;

    /// <summary>
    /// The rating validator.
    /// </summary>
    public class RatingValidator : AbstractValidator<RatingViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingValidator"/> class.
        /// </summary>
        public RatingValidator()
        {
            this.RuleFor(x => x.EntityVersionId)
                .NotEqual(0)
                .WithMessage("EntityVersionId is mandatory.");

            this.RuleFor(x => x.Rating)
                .InclusiveBetween(1, 5)
                .WithMessage("Rating must be between 1 and 5 stars.");
        }
    }
}
