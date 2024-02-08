namespace LearningHub.Nhs.Models.Catalogue
{
    /// <summary>
    /// The CatalogueUserBatchRequestViewModel class.
    /// </summary>
    public class RestrictedCatalogueUsersRequestViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the email filter.
        /// </summary>
        public string EmailAddressFilter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the catalogue admins.
        /// </summary>
        public bool IncludeCatalogueAdmins { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include the platform admins.
        /// </summary>
        public bool IncludePlatformAdmins { get; set; }

        /// <summary>
        /// Gets or sets the skip.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Gets or sets the take.
        /// </summary>
        public int Take { get; set; }
    }
}
