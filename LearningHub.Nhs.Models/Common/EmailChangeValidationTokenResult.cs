namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// EmailChangeValidationTokenResult.
    /// </summary>
    public class EmailChangeValidationTokenResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether valid.
        /// </summary>
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or sets the token issue.
        /// </summary>
        public string TokenIssue { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }
    }
}
