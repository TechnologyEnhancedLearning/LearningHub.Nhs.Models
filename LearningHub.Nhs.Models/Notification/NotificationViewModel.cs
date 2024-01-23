// <copyright file="NotificationViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Notification
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The notification view model.
    /// </summary>
    public class NotificationViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [Required(ErrorMessage = "Enter a title")]
        [StringLength(60, ErrorMessage = "The title should be less than 60 characters including spaces.")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [Required(ErrorMessage = "Enter a message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Required(ErrorMessage = "Enter a start date")]
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Required(ErrorMessage = "Enter an end date")]
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether user dismissable.
        /// </summary>
        public bool UserDismissable { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the amend user name.
        /// </summary>
        public string AmendUserName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the amend date.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTimeOffset AmendDate { get; set; }

        /// <summary>
        /// Gets or sets notification type.
        /// </summary>
        [Required(ErrorMessage = "Select an option from the list")]
        public NotificationTypeEnum NotificationType { get; set; }

        /// <summary>
        /// Gets or sets notification priority.
        /// </summary>
        [Required(ErrorMessage = "Select an option from the list")]
        public NotificationPriorityEnum NotificationPriority { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is user or system notification.
        /// </summary>
        public bool IsUserSpecific { get; set; }
    }
}
