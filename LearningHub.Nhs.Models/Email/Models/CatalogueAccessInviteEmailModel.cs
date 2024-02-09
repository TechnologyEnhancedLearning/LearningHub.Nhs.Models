namespace LearningHub.Nhs.Models.Email.Models
{
    /// <summary>
    /// The CatalogueAccessInviteEmailModel.
    /// </summary>
    public class CatalogueAccessInviteEmailModel
    {
        /// <summary>
        /// Gets or sets the admin full name.
        /// </summary>
        public string AdminFullName { get; set; }

        /// <summary>
        /// Gets or sets the greeting. If there is a user for the invite email address, will say "Dear UserFirstName", otherwise "Hi there".
        /// </summary>
        public string Greeting { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the catalogue url.
        /// </summary>
        public string CatalogueUrl { get; set; }

        /// <summary>
        /// Gets or sets the create account url.
        /// </summary>
        public string CreateAccountUrl { get; set; }
    }
}
