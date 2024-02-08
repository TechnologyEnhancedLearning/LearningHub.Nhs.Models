namespace LearningHub.Nhs.Models.OpenAthens
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The begin open athens link to learning hub user.
    /// </summary>
    public class BeginOpenAthensLinkToLearningHubUser : OpenAthensLinkSharedDetails
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your username.")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter your password.")]
        public string Password { get; set; }
    }
}
