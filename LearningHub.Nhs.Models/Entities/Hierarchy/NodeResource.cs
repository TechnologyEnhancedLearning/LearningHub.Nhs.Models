namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using LearningHub.Nhs.Models.Entities.Resource;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The node resource.
    /// </summary>
    public class NodeResource : EntityBase
    {
        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the version status enum.
        /// </summary>
        public virtual VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the publication id.
        /// </summary>
        public int? PublicationId { get; set; }
    }
}