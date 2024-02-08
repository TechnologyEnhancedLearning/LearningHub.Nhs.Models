namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The node path node.
    /// </summary>
    public class NodePathNode : EntityBase
    {
        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the depth.
        /// </summary>
        public int Depth { get; set; }

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// Gets or sets the node path.
        /// </summary>
        public virtual NodePath NodePath { get; set; }
    }
}
