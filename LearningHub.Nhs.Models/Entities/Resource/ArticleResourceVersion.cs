namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The article resource version.
    /// </summary>
    public partial class ArticleResourceVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleResourceVersion"/> class.
        /// </summary>
        public ArticleResourceVersion()
        {
            this.ArticleResourceVersionFile = new HashSet<ArticleResourceVersionFile>();
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the article resource version file.
        /// </summary>
        public virtual ICollection<ArticleResourceVersionFile> ArticleResourceVersionFile { get; set; }
    }
}
