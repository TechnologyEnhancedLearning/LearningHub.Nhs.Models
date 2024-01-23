// <copyright file="UserTermsAndConditionsValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Common;
    using FluentValidation;

    /// <summary>
    /// The user terms and conditions validator.
    /// </summary>
    public class UserTermsAndConditionsValidator : AbstractValidator<UserTermsAndConditionsViewModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserTermsAndConditionsValidator"/> class.
        /// </summary>
        public UserTermsAndConditionsValidator()
        {
            this.RuleFor(x => x.TermsAndConditionsId)
                .GreaterThan(0)
                .WithMessage("TermsAndConditionsId is a required field");

            this.RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("UserId is a required field");
        }
    }
}
