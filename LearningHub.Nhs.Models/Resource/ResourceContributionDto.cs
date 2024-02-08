namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The resource contribution data transfer object.
    /// </summary>
    public class ResourceContributionDto
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersionId.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the version status enumeration.
        /// </summary>
        public int VersionStatusId { get; set; }

        /// <summary>
        /// Gets or sets the resource accessibility id.
        /// </summary>
        public int ResourceAccessibilityId { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the resource type enumeration.
        /// </summary>
        public int ResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether resource is InEdit.
        /// </summary>
        public bool InEdit { get; set; }

        /// <summary>
        /// Gets or sets the Draft Resource Version Id.
        /// </summary>
        public int? DraftResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        public DateTimeOffset? PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unpublished by admin.
        /// </summary>
        public bool UnpublishedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has validation errors.
        /// </summary>
        public bool HasValidationErrors { get; set; }
    }
}
