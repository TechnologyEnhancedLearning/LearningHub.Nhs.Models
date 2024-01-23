// <copyright file="DashboardResourceDto.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Dashboard
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The ResourceDto.
    /// </summary>
    public class DashboardResourceDto
    {
        /// <summary>
        /// Gets or sets the resourceId.
        /// </summary>
        [Key]
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeId.
        /// </summary>
        public int ResourceTypeId { get; set; }

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
    }
}