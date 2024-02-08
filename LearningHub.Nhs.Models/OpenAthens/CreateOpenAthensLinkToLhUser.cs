namespace LearningHub.Nhs.Models.OpenAthens
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The create open athens link to lh user.
    /// </summary>
    public class CreateOpenAthensLinkToLhUser : OpenAthensLinkSharedDetails
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter a first name.")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter a last name.")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter an email address.")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the verify email.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm your email address.")]
        [Compare(nameof(EmailAddress), ErrorMessage = "Email addresses do not match.")]
        [Display(Name = "Confirm email")]
        public string VerifyEmail { get; set; }
    }
}
