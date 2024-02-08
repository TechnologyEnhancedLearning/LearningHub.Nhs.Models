namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource version flag.
    /// </summary>
    public partial class ResourceVersionFlag : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the resolution.
        /// </summary>
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
