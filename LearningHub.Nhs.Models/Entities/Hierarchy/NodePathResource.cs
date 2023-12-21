// <copyright file="NodePathResource.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The node path resource.
    /// </summary>
    public class NodePathResource : EntityBase
    {
        /// <summary>
        /// Gets or sets the node path.
        /// </summary>
        public virtual NodePath NodePath { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

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