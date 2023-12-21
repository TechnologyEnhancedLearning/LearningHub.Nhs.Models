// <copyright file="ReportValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities.Reporting;

    /// <summary>
    /// The report validator.
    /// </summary>
    public class ReportValidator : AbstractValidator<Report>
    {
        /// <summary>
        /// The name max length.
        /// </summary>
        public const int NameMaxLength = 128;

        /// <summary>
        /// The filename max length.
        /// </summary>
        public const int FileNameMaxLength = 512;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportValidator"/> class.
        /// </summary>
        public ReportValidator()
        {
            this.RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Report name is mandatory.")
            .MaximumLength(NameMaxLength)
            .WithMessage(string.Format("Name length cannot exceed {0} characters.", NameMaxLength));

            this.RuleFor(x => x.FileName)
            .NotEmpty()
            .WithMessage("File Name is mandatory.")
            .MaximumLength(FileNameMaxLength)
            .WithMessage(string.Format("File Name length cannot exceed {0} characters.", FileNameMaxLength));

            this.RuleFor(x => x.Hash)
           .NotEmpty()
           .WithMessage("Hash code is mandatory.");

            this.RuleFor(x => x.ReportStatusId)
               .NotEqual(0)
               .WithMessage("Report Status Id must be greater than 0.");

            this.RuleFor(x => x.ReportTypeId)
               .NotEqual(0)
               .WithMessage("Report Type Id must be greater than 0.");

            this.RuleFor(x => x.ReportPages)
              .NotEmpty()
              .WithMessage("Report pages collection is required").When(x => x.IsNew());

            this.RuleForEach(x => x.ReportPages)
               .NotNull()
               .WithMessage("Html in report pages collection is null or empty").When(x => x.IsNew());

            this.RuleForEach(x => x.ReportPages).SetValidator(new ReportPageValidator()).When(x => x.IsNew());
        }
    }
}
