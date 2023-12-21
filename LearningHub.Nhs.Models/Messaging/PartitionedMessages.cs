// <copyright file="PartitionedMessages.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Messaging
{
    using System.Collections.Generic;

    /// <summary>
    /// The PartitionedMessages class.
    /// </summary>
    public class PartitionedMessages
    {
        /// <summary>
        /// Gets or sets the email messages.
        /// </summary>
        public List<MessageViewModel> EmailMessages { get; set; }

        /// <summary>
        /// Gets or sets the notification messages.
        /// </summary>
        public List<MessageViewModel> NotificationMessages { get; set; }
    }
}
