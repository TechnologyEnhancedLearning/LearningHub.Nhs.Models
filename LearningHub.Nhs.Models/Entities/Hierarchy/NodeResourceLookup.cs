namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The node resource lookup.
    /// </summary>
    public class NodeResourceLookup : EntityBase
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
    }
}