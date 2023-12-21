// <copyright file="NodeContentBrowseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using LearningHub.Nhs.Models.Common;

    /// <summary>
    /// The node content view model.
    /// </summary>
    public class NodeContentBrowseViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the NodeTypeId.
        /// </summary>
        public int NodeTypeId { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the NodeVersionId.
        /// </summary>
        public int? NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int? ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersionId.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int? ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the DisplayOrder.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeId.
        /// </summary>
        public int? ResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the VersionStatusId.
        /// </summary>
        public int? VersionStatusId { get; set; }

        /// <summary>
        /// Gets or sets the AuthoredBy.
        /// </summary>
        public string AuthoredBy { get; set; }

        /// <summary>
        /// Gets or sets the DurationInMilliseconds. Only applies to video/audio resources.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the IsEmptyFolder.
        /// </summary>
        public bool IsEmptyFolder { get; set; }

        /// <summary>
        /// Gets or sets the RatingSummaryBasicViewModel.
        /// Applies only to NodeContent that represents a Resource.
        /// </summary>
        [NotMapped]
        public RatingSummaryBasicViewModel RatingSummaryBasicViewModel { get; set; }
    }
}
