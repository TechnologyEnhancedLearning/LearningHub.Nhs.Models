// <copyright file="NodePath.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The node path.
    /// </summary>
    public class NodePath : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodePath"/> class.
        /// </summary>
        public NodePath()
        {
            this.ResourceReference = new HashSet<ResourceReference>();
        }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the node path string.
        /// </summary>
        public string NodePathString { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the node path is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the node path node.
        /// </summary>
        public virtual ICollection<NodePathNode> NodePathNode { get; set; }

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node.
        /// </summary>
        public virtual Node CatalogueNode { get; set; }

        /// <summary>
        /// Gets or sets the node path display.
        /// </summary>
        public virtual NodePathDisplay NodePathDisplay { get; set; }

        /// <summary>
        /// Gets or sets the resource reference.
        /// </summary>
        public virtual ICollection<ResourceReference> ResourceReference { get; set; }
    }
}
