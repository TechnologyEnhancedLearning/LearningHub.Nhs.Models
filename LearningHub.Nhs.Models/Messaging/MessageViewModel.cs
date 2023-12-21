// <copyright file="MessageViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Messaging
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The MessageViewModel class.
    /// </summary>
    public class MessageViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the send information for the message.
        /// </summary>
        public List<MessageSendViewModel> Sends { get; set; }

        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        public int? NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the notification priority.
        /// </summary>
        public int? NotificationPriority { get; set; }

        /// <summary>
        /// Gets or sets the notification start date.
        /// </summary>
        public DateTimeOffset? NotificationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the notification end date.
        /// </summary>
        public DateTimeOffset? NotificationEndDate { get; set; }
    }
}
