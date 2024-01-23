// <copyright file="RecentlyAddedResourceViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The RecentlyAddedResource view model.
    /// </summary>
    public class RecentlyAddedResourceViewModel
    {
        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        [Key]
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeId.
        /// </summary>
        public int ResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeName.
        /// </summary>
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the duration in millseconds.
        /// </summary>
        public int DurationInMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the AverageRating.
        /// </summary>
        public decimal AverageRating { get; set; }
    }
}
