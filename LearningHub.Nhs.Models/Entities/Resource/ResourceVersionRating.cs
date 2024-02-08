namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource version rating.
    /// </summary>
    public partial class ResourceVersionRating : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the job role id.
        /// </summary>
        public int JobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
