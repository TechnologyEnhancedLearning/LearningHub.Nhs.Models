namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The unpublish view model validator.
    /// </summary>
    public class UnpublishViewModelValidator : AbstractValidator<Resource.UnpublishViewModel>
    {
        /// <summary>
        /// The details max length.
        /// </summary>
        public const int DetailsMaxLength = 1024;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnpublishViewModelValidator"/> class.
        /// </summary>
        public UnpublishViewModelValidator()
        {
            this.RuleFor(x => x.Details)
            .NotEmpty()
            .When(x => x.SetFlag)
            .WithMessage("Details is mandatory.")
            .MaximumLength(DetailsMaxLength)
            .WithMessage(string.Format("Details cannot exceed {0} characters.", DetailsMaxLength));
        }
    }
}
