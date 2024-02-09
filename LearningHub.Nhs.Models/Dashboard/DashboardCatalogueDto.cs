namespace LearningHub.Nhs.Models.Dashboard
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The CatalogueDto.
    /// </summary>
    public class DashboardCatalogueDto
    {
        /// <summary>
        /// Gets or sets the NodeId
        /// Gets or sets nodeId..
        /// </summary>
        [Key]
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the banner url..
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
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted access..
        /// </summary>
        public bool RestrictedAccess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has access..
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
  }
}
