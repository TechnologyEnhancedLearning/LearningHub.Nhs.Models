namespace LearningHub.Nhs.Models.Entities.Messaging
{
    using System;

    /// <summary>
    /// The MessageMetaData class.
    /// </summary>
    public class MessageMetaData : EntityBase
    {
        /// <summary>
        /// Gets or sets the notification priority.
        /// </summary>
        public int NotificationPriority { get; set; }

        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        public int NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the notification start date.
        /// </summary>
        public DateTimeOffset NotificationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the notification end date.
        /// </summary>
        public DateTimeOffset NotificationEndDate { get; set; }

        /// <summary>
        /// Gets or sets the message send id.
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public Message Message { get; set; }
    }
}
