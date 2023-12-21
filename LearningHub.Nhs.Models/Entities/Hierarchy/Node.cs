// <copyright file="Node.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The node.
    /// </summary>
    public partial class Node : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        public Node()
        {
            this.NodePaths = new HashSet<NodePath>();
            this.NodePathNodes = new HashSet<NodePathNode>();
            this.NodeVersion = new HashSet<NodeVersion>();
            this.NodeResource = new HashSet<NodeResource>();
        }

        /// <summary>
        /// Gets or sets the current node version id.
        /// </summary>
        public int? CurrentNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether hidden.
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets the current node version.
        /// </summary>
        public virtual NodeVersion CurrentNodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the node type enum.
        /// </summary>
        public virtual NodeTypeEnum NodeTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the node paths.
        /// </summary>
        public virtual ICollection<NodePath> NodePaths { get; set; }

        /// <summary>
        /// Gets or sets the node path nodes.
        /// </summary>
        public virtual ICollection<NodePathNode> NodePathNodes { get; set; }

        /// <summary>
        /// Gets or sets the node link child node.
        /// </summary>
        public virtual ICollection<NodeLink> NodeLinkChildNode { get; set; }

        /// <summary>
        /// Gets or sets the node link parent node.
        /// </summary>
        public virtual ICollection<NodeLink> NodeLinkParentNode { get; set; }

        /// <summary>
        /// Gets or sets the node version.
        /// </summary>
        public virtual ICollection<NodeVersion> NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the node resource.
        /// </summary>
        public virtual ICollection<NodeResource> NodeResource { get; set; }
    }
}
