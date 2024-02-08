namespace LearningHub.Nhs.Models.Catalogue
{
    using System;

    /// <summary>
    /// The CatalogueResourceViewModel.
    /// </summary>
    public class CatalogueResourceViewModel
    {
        /// <summary>
        /// Gets or sets the resourceId.
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the createdOn.
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets ResourceVersionId.
        /// </summary>
        public string ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets resourceReferenceId.
        /// </summary>
        public string ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets rating count.
        /// </summary>
        public int? Rating { get; set; }

        /// <summary>
        /// Gets or sets rating.
        /// </summary>
        public int? RatingCount { get; set; }

        /// <summary>
        /// Gets or sets authoredBy.
        /// </summary>
        public string AuthoredBy { get; set; }

        /// <summary>
        /// Gets or sets organisation.
        /// </summary>
        public string Organisation { get; set; }

        /// <summary>
        /// Gets or sets authored date text.
        /// </summary>
        public string AuthoredDateText { get; set; }
    }
}