// <copyright file="FullMessageDto.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Messaging
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The FullMessageDto, returned from the GetPendingMessages stored procedure.
    /// </summary>
    public class FullMessageDto
    {
        /// <summary>
        /// Gets or sets the full message dto id.
        /// </summary>
        [Key]
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
        /// Gets or sets the message type id.
        /// </summary>
        public int MessageTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets user group id.
        /// </summary>
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the message send id.
        /// </summary>
        public int MessageSendId { get; set; }

        /// <summary>
        /// Gets or sets the message id.
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Gets or sets the notification priority.
        /// </summary>
        public int? NotificationPriority { get; set; }

        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        public int? NotificationType { get; set; }

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
