namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The publish view model.
    /// </summary>
    public class PublishViewModel
    {
        /// <summary>
        /// Gets or sets the publisher action enum.
        /// </summary>
        public PublisherActionEnum PublisherAction { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is major revision.
        /// </summary>
        public bool IsMajorRevision { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        public DateTimeOffset? PublicationDate { get; set; }
    }
}
