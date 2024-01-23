// <copyright file="NodeLink.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The node link.
    /// </summary>
    public class NodeLink : EntityBase
    {
        /// <summary>
        /// Gets or sets the parent node id.
        /// </summary>
        public int ParentNodeId { get; set; }

        /// <summary>
        /// Gets or sets the child node id.
        /// </summary>
        public int ChildNodeId { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the child node.
        /// </summary>
        public virtual Node ChildNode { get; set; }

        /// <summary>
        /// Gets or sets the parent node.
        /// </summary>
        public virtual Node ParentNode { get; set; }
    }
}
