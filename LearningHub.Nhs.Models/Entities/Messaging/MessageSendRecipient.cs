namespace LearningHub.Nhs.Models.Entities.Messaging
{
    /// <summary>
    /// The MessageSendRecipient class.
    /// </summary>
    public class MessageSendRecipient : EntityBase
    {
        /// <summary>
        /// Gets or sets the message send id.
        /// </summary>
        public int MessageSendId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int? UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the user group.
        /// </summary>
        public UserGroup UserGroup { get; set; }

        /// <summary>
        /// Gets or sets the message send.
        /// </summary>
        public MessageSend MessageSend { get; set; }
    }
}
