namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource version author.
    /// </summary>
    public partial class ResourceVersionAuthor : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the author user id.
        /// </summary>
        public int? AuthorUserId { get; set; }

        /// <summary>
        /// Gets or sets the author name.
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// Gets or sets the author organisation.
        /// </summary>
        public string Organisation { get; set; }

        /// <summary>
        /// Gets or sets the author role.
        /// </summary>
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the author is also the contributor.
        /// </summary>
        public bool IsContributor { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
