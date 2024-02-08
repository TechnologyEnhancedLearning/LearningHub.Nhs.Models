namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The article view model.
    /// </summary>
    public class ArticleViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the category ids.
        /// </summary>
        public ICollection<int> CategoryIds { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        public string DateCreated { get; set; }

        /// <summary>
        /// Gets or sets the next review date.
        /// </summary>
        public DateTimeOffset NextReviewDate { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the attachments.
        /// </summary>
        public List<FileViewModel> Files { get; set; }
    }
}