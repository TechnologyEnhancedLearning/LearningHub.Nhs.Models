// <copyright file="ResourceAccessibility.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The ResourceAccessibility.
    /// </summary>
    public class ResourceAccessibility : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAccessibility"/> class.
        /// </summary>
        public ResourceAccessibility()
        {
            this.ResourceVersion = new HashSet<ResourceVersion>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the scorm resource version.
        /// </summary>
        public virtual ICollection<ResourceVersion> ResourceVersion { get; set; }
    }
}
