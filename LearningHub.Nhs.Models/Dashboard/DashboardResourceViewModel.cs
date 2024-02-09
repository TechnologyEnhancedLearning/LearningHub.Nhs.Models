namespace LearningHub.Nhs.Models.Dashboard
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Common;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Provider;

    /// <summary>
    /// The ResourceViewModel.
    /// </summary>
    public class DashboardResourceViewModel
    {
        /// <summary>
        /// Gets or sets the resourceId.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        public ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Gets or sets ResourceVersionId.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets resourceReferenceId.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the DurationInMilliseconds.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets authoredBy.
        /// </summary>
        public string AuthoredBy { get; set; }

        /// <summary>
        /// Gets or sets organisation.
        /// </summary>
        public string Organisation { get; set; }

        /// <summary>
        /// Gets or sets catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the badge url.
        /// </summary>
        public string BadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets ratingSummary.
        /// </summary>
        public RatingSummaryViewModel RatingSummary { get; set; }

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
        /// Gets or sets the AverageRating.
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the RatingCount.
        /// </summary>
        public int RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public List<ProviderViewModel> Providers { get; set; }
    }
}