namespace LearningHub.Nhs.Models.Messaging
{
    using System;

    /// <summary>
    /// The MessageMetaDataViewModel class.
    /// </summary>
    public class MessageMetaDataViewModel
    {
        /// <summary>
        /// Gets or sets the notification type.
        /// </summary>
        public int NotificationType { get; set; }

        /// <summary>
        /// Gets or sets the notification priority.
        /// </summary>
        public int NotificationPriority { get; set; }

        /// <summary>
        /// Gets or sets the notification start date.
        /// </summary>
        public DateTimeOffset NotificationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the notification end date.
        /// </summary>
        public DateTimeOffset NotificationEndDate { get; set; }
    }
}
