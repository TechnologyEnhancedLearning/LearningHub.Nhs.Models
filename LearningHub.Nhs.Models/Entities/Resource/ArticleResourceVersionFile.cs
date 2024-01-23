// <copyright file="ArticleResourceVersionFile.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The article resource version file.
    /// </summary>
    public partial class ArticleResourceVersionFile : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleResourceVersionFile"/> class.
        /// </summary>
        public ArticleResourceVersionFile()
        {
        }

        /// <summary>
        /// Gets or sets the article resource version id.
        /// </summary>
        public int ArticleResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the article resource version.
        /// </summary>
        public virtual ArticleResourceVersion ArticleResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }
    }
}
