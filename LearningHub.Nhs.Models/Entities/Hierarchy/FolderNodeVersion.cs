namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The FolderNodeVersion.
    /// </summary>
    public class FolderNodeVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderNodeVersion"/> class.
        /// </summary>
        public FolderNodeVersion()
        {
        }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the node version.
        /// </summary>
        public virtual NodeVersion NodeVersion { get; set; }
    }
}
