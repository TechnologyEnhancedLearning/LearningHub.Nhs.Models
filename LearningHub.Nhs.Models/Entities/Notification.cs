// <copyright file="Notification.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The notification.
    /// </summary>
    public class Notification : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification()
        {
            this.UserNotification = new HashSet<UserNotification>();
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether user dismissable.
        /// </summary>
        public bool UserDismissable { get; set; }

        /// <summary>
        /// Gets or sets the notification type enum.
        /// </summary>
        public NotificationTypeEnum NotificationTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the notification priority enum.
        /// </summary>
        public NotificationPriorityEnum NotificationPriorityEnum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is user or system notification.
        /// </summary>
        public bool IsUserSpecific { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }

        /// <summary>
        /// Gets or sets the user notification.
        /// </summary>
        public virtual ICollection<UserNotification> UserNotification { get; set; }
    }
}