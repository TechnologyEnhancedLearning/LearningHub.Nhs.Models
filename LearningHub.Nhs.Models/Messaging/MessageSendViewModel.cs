namespace LearningHub.Nhs.Models.Messaging
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The MessageSendViewModel class.
    /// </summary>
    public class MessageSendViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the message type.
        /// </summary>
        public MessageTypes MessageType { get; set; }

        /// <summary>
        /// Gets or sets the recipients.
        /// - used for emails.
        /// </summary>
        public List<string> EmailRecipients { get; set; }

        /// <summary>
        /// Gets or sets the user ids.
        /// - used for notifications.
        /// </summary>
        public List<int> UserIds { get; set; }
    }
}
