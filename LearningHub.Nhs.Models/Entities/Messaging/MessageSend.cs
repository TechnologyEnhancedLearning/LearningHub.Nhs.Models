namespace LearningHub.Nhs.Models.Entities.Messaging
{
    using System.Collections.Generic;

    /// <summary>
    /// The MessageSend class.
    /// </summary>
    public class MessageSend : EntityBase
    {
        /// <summary>
        /// Gets or sets the message id.
        /// </summary>
        public int MessageId { get; set; }

        /// <summary>
        /// Gets or sets the message type id.
        /// </summary>
        public int MessageTypeId { get; set; }

        /// <summary>
        /// Gets or sets the message send status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public Message Message { get; set; }

        /// <summary>
        /// Gets or sets the message type.
        /// </summary>
        public MessageType MessageType { get; set; }

        /// <summary>
        /// Gets or sets the recipients.
        /// </summary>
        public List<MessageSendRecipient> Recipients { get; set; }
    }
}
