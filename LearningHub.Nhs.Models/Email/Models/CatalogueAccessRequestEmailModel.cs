namespace LearningHub.Nhs.Models.Email.Models
{
    /// <summary>
    /// The CatalogueAccessRequestEmailModel class.
    /// </summary>
    public class CatalogueAccessRequestEmailModel
    {
        /// <summary>
        /// Gets or sets the full name of the user requesting access.
        /// </summary>
        public string UserFullName { get; set; }

        /// <summary>
        /// Gets or sets email address of the user requesting access.
        /// </summary>
        public string UserEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the user message.
        /// </summary>
        public string UserMessage { get; set; }

        /// <summary>
        /// Gets or sets the admin first name.
        /// </summary>
        public string AdminFirstName { get; set; }

        /// <summary>
        /// Gets or sets the name of the catalogue to which access has been requested.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the url to manage the access request.
        /// </summary>
        public string ManageAccessUrl { get; set; }
    }
}
