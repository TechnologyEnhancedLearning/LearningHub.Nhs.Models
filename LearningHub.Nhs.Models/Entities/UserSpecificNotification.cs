// <copyright file="UserSpecificNotification.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The UserSpecificNotification.
    /// </summary>
    public class UserSpecificNotification
    {
        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        public Notification Notification { get; set; }

        /// <summary>
        /// Gets or sets the UserNotification.
        /// </summary>
        public UserNotification UserNotification { get; set; }
    }
}