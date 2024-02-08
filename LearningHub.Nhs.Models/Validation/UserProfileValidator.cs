﻿namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// The user group validator.
    /// </summary>
    public class UserProfileValidator : AbstractValidator<UserProfile>
    {
        /// <summary>
        /// The name max length.
        /// </summary>
        public const int UserNameMaxLength = 50;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileValidator"/> class.
        /// </summary>
        public UserProfileValidator()
        {
            this.RuleFor(x => x.Id)
            .NotEqual(0)
            .WithMessage("Id is mandatory.");

            this.RuleFor(x => x.UserName)
            .NotEmpty()
            .WithMessage("UserName is mandatory.")
            .MaximumLength(UserNameMaxLength)
            .WithMessage(string.Format("Name length cannot exceed {0} characters.", UserNameMaxLength));
        }
    }
}
