// <copyright file="LoginWizardStageActivityValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Entities;
    using FluentValidation;

    /// <summary>
    /// The login wizard stage activity validator.
    /// </summary>
    public class LoginWizardStageActivityValidator : AbstractValidator<LoginWizardStageActivity>
    {
        /// <summary>
        /// The text max length.
        /// </summary>
        public const int TextMaxLength = 1000;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginWizardStageActivityValidator"/> class.
        /// </summary>
        public LoginWizardStageActivityValidator()
        {
            this.RuleFor(x => x.LoginWizardStageId)
                .GreaterThan(0)
                .WithMessage("LoginWizardStageId is a required field");

            this.RuleFor(x => x.UserId)
                .GreaterThan(0)
                .WithMessage("UserId is a required field");
        }
    }
}
