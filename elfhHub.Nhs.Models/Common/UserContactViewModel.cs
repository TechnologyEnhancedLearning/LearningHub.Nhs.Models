namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// For sending an email from an admin user to a regular user, with custom subject and body content.
    /// </summary>
    public class UserContactViewModel
    {
        /// <summary>
        /// Gets or sets the id of the regular user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the id of the admin user.
        /// </summary>
        public int AdminId { get; set; }

        /// <summary>
        /// Gets or sets the email address of the regular user, to whom the email will be sent.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the email subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the email body.
        /// </summary>
        public string Body { get; set; }
    }
}
