// <copyright file="UserHistoryValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Validation
{
    using elfhHub.Nhs.Models.Common;
    using FluentValidation;

    /// <summary>
    /// The user history validator.
    /// </summary>
    public class UserHistoryValidator : AbstractValidator<UserHistoryViewModel>
    {
        /// <summary>
        /// The text max length.
        /// </summary>
        public const int TextMaxLength = 1000;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserHistoryValidator"/> class.
        /// </summary>
        public UserHistoryValidator()
        {
            this.RuleFor(x => x.Detail)
            .MaximumLength(TextMaxLength)
            .WithMessage(string.Format("Detail cannot exceed {0} characters.", TextMaxLength));

            this.RuleFor(x => x.BrowserName)
            .MaximumLength(TextMaxLength)
            .WithMessage(string.Format("BrowserName cannot exceed {0} characters.", TextMaxLength));

            this.RuleFor(x => x.BrowserVersion)
            .MaximumLength(TextMaxLength)
            .WithMessage(string.Format("BrowserVersion cannot exceed {0} characters.", TextMaxLength));

            this.RuleFor(x => x.UrlReferer)
            .MaximumLength(TextMaxLength)
            .WithMessage(string.Format("UrlReferer cannot exceed {0} characters.", TextMaxLength));

            this.RuleFor(x => x.LoginIP)
            .MaximumLength(TextMaxLength)
            .WithMessage(string.Format("LoginIP cannot exceed {0} characters.", TextMaxLength));
        }
    }
}
