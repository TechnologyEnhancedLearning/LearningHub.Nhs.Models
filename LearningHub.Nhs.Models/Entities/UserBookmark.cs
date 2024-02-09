namespace LearningHub.Nhs.Models.Entities
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// Defines the <see cref="UserBookmark" />.
    /// </summary>
    public class UserBookmark : EntityBase
    {
        /// <summary>
        /// Gets or sets the BookmarkTypeId.
        /// </summary>
        public int BookmarkTypeId { get; set; }

        /// <summary>
        /// Gets or sets the ParentId.
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int? ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the Link.
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets the BookmarkType.
        /// </summary>
        public virtual BookmarkType BookmarkType { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReference.
        /// </summary>
        public virtual ResourceReference ResourceReference { get; set; }
    }
}
