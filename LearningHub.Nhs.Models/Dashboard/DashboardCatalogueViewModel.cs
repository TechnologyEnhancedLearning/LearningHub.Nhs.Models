namespace LearningHub.Nhs.Models.Dashboard
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Provider;

    /// <summary>
    /// The CatalogueViewModel.
    /// </summary>
    public class DashboardCatalogueViewModel
    {
        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the banner url.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the badge url.
        /// </summary>
        public string BadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue card image url.
        /// </summary>
        public string CardImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted access.
        /// </summary>
        public bool RestrictedAccess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has access.
        /// </summary>
        public bool HasAccess { get; set; }

        /// <summary>
        /// Gets or sets the BookmarkId.
        /// </summary>
        public int? BookmarkId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsBookmarked.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public List<ProviderViewModel> Providers { get; set; }
  }
}