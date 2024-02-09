namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The embedded resource version.
    /// </summary>
    public partial class EmbeddedResourceVersion : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the embed code.
        /// </summary>
        public string EmbedCode { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
