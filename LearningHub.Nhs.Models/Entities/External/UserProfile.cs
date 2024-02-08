namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The user profile.
    /// </summary>
    public class UserProfile : EntityBase
    {
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user profile is active.
        /// </summary>
        public bool Active { get; set; }
    }
}
