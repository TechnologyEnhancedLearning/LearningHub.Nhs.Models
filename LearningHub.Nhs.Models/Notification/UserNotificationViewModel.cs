namespace LearningHub.Nhs.Models.Notification
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The user notification view model.
    /// </summary>
    public class UserNotificationViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the notification id.
        /// </summary>
        public int NotificationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dismissed.
        /// </summary>
        public bool Dismissed { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether user dismissable.
        /// </summary>
        public bool UserDismissable { get; set; }

        /// <summary>
        /// Gets or sets the read-on date.
        /// </summary>
        public DateTimeOffset? ReadOnDate { get; set; }

        /// <summary>
        /// Gets a value indicating whether read.
        /// </summary>
        public bool Read => this.ReadOnDate.HasValue;

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the amend user name.
        /// </summary>
        public string AmendUserName { get; set; }

        /// <summary>
        /// Gets or sets notification type.
        /// </summary>
        public NotificationTypeEnum NotificationType { get; set; }

        /// <summary>
        /// Gets or sets notification priority.
        /// </summary>
        public NotificationPriorityEnum NotificationPriority { get; set; }
    }
}