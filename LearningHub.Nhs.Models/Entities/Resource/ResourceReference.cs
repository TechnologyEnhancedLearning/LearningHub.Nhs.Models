// <copyright file="ResourceReference.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities.Hierarchy;

    /// <summary>
    /// The resource reference.
    /// </summary>
    public class ResourceReference : EntityBase
    {
        /// <summary>
        /// Gets or sets the original resource reference id.
        /// </summary>
        public int OriginalResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the node path  id.
        /// </summary>
        public int? NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Gets or sets the node path.
        /// </summary>
        public virtual NodePath NodePath { get; set; }
    }
}
