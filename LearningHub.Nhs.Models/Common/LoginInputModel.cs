namespace LearningHub.Nhs.Models.Common
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The login input model.
    /// </summary>
    public class LoginInputModel
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [Required(ErrorMessage = "Enter your username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether remember login.
        /// </summary>
        public bool RememberLogin { get; set; }

        /// <summary>
        /// Gets or sets the return url.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
