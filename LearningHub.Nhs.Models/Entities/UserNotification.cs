// <copyright file="UserNotification.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user notification.
    /// </summary>
    public class UserNotification : EntityBase
    {
        /// <summary>
        /// Gets or sets the notification id.
        /// </summary>
        public int NotificationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dismissed.
        /// </summary>
        public bool Dismissed { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the read-on date.
        /// </summary>
        public DateTimeOffset? ReadOnDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        public virtual Notification Notification { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }
    }
}
