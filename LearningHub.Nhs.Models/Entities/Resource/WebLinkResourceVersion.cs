namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The web link resource version.
    /// </summary>
    public partial class WebLinkResourceVersion : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the web link url.
        /// </summary>
        public string WebLinkUrl { get; set; }

        /// <summary>
        /// Gets or sets the display text.
        /// </summary>
        public string DisplayText { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
