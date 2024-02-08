namespace LearningHub.Nhs.Models.Catalogue
{
    using System;

    /// <summary>
    /// The CatalogueAccessDetailsViewModel class.
    /// </summary>
    public class CatalogueAccessDetailsViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether the user can manage the catalogue.
        /// </summary>
        public bool CanManage { get; set; }

        /// <summary>
        /// Gets or sets the time access was accepted.
        /// </summary>
        public DateTimeOffset? AcceptedDate { get; set; }

        /// <summary>
        /// Gets or sets the time access was rejected.
        /// </summary>
        public DateTimeOffset? RejectedDate { get; set; }

        /// <summary>
        /// Gets or sets the time access was requested.
        /// </summary>
        public DateTimeOffset? RequestedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has dismissed the access request.
        /// </summary>
        public bool UserDismissed { get; set; }
    }
}
