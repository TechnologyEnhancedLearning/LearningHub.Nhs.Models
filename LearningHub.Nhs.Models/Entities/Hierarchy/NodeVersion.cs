namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The node version.
    /// </summary>
    public class NodeVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeVersion"/> class.
        /// </summary>
        public NodeVersion()
        {
        }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the version status enum.
        /// </summary>
        public VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the major version.
        /// </summary>
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the minor version.
        /// </summary>
        public int? MinorVersion { get; set; }

        /// <summary>
        /// Gets or sets the publication.
        /// </summary>
        public virtual Publication Publication { get; set; }

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// Gets or sets the node where current.
        /// </summary>
        public virtual Node NodeWhereCurrent { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node version.
        /// </summary>
        public virtual CatalogueNodeVersion CatalogueNodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the folder node version.
        /// </summary>
        public virtual FolderNodeVersion FolderNodeVersion { get; set; }
    }
}
