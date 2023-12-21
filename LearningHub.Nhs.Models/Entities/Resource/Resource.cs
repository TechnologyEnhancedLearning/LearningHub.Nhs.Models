// <copyright file="Resource.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Activity;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource.
    /// </summary>
    public partial class Resource : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Resource"/> class.
        /// </summary>
        public Resource()
        {
            this.ResourceVersion = new HashSet<ResourceVersion>();
            this.NodeResource = new HashSet<NodeResource>();
            this.ResourceReference = new HashSet<ResourceReference>();
        }

        /// <summary>
        /// Gets or sets the current resource version id.
        /// </summary>
        public int? CurrentResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the original resource version id for a duplicated resource.
        /// </summary>
        public int? DuplicatedFromResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the original resource version for a duplicated resource.
        /// </summary>
        public virtual ResourceVersion DuplicatedFromResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource type enum.
        /// </summary>
        public virtual ResourceTypeEnum ResourceTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the current resource version.
        /// </summary>
        public virtual ResourceVersion CurrentResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ICollection<ResourceVersion> ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the node resource.
        /// </summary>
        public virtual ICollection<NodeResource> NodeResource { get; set; }

        /// <summary>
        /// Gets or sets the resource reference.
        /// </summary>
        public virtual ICollection<ResourceReference> ResourceReference { get; set; }

        /// <summary>
        /// Gets or sets the resource activity.
        /// </summary>
        public virtual ICollection<ResourceActivity> ResourceActivity { get; set; }
    }
}
