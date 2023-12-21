// <copyright file="ReportPageValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities.Reporting;

    /// <summary>
    /// The report page validator.
    /// </summary>
    public class ReportPageValidator : AbstractValidator<ReportPage>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportPageValidator"/> class.
        /// </summary>
        public ReportPageValidator()
        {
            this.RuleFor(x => x.Html)
             .NotEmpty()
             .WithMessage("Html is mandatory in report page object");

            this.RuleFor(x => x.ReportOrientationModeId)
               .NotEqual(0)
               .WithMessage("Report Orientation Mode Id should be greater than 0.");
        }
    }
}
