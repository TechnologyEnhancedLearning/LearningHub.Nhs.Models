namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The login result internal.
    /// </summary>
    public class LoginResultInternal : LoginResult
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        public string UserName { get; set; }
    }
}