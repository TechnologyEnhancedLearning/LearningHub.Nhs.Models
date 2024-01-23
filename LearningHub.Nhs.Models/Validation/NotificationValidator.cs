// <copyright file="NotificationValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using FluentValidation;

    /// <summary>
    /// The notification validator.
    /// </summary>
    public class NotificationValidator : AbstractValidator<Entities.Notification>
    {
        /// <summary>
        /// The title max length.
        /// </summary>
        public const int TitleMaxLength = 300;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationValidator"/> class.
        /// </summary>
        public NotificationValidator()
        {
            this.RuleFor(x => x.Title)
            .NotEmpty()
            .WithMessage("Title is mandatory.")
            .MaximumLength(TitleMaxLength)
            .WithMessage(string.Format("Title cannot exceed {0} characters.", TitleMaxLength));

            this.RuleFor(x => x.Message)
            .NotEmpty()
            .WithMessage("Message is mandatory.");
        }
    }
}
