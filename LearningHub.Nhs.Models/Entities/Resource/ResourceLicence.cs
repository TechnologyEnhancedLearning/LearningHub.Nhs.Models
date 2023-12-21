// <copyright file="ResourceLicence.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The file type.
    /// </summary>
    public partial class ResourceLicence : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceLicence"/> class.
        /// </summary>
        public ResourceLicence()
        {
            this.ResourceVersion = new HashSet<ResourceVersion>();
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual ICollection<ResourceVersion> ResourceVersion { get; set; }
    }
}
