// <copyright file="FileType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The file type.
    /// </summary>
    public partial class FileType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileType"/> class.
        /// </summary>
        public FileType()
        {
            this.File = new HashSet<File>();
        }

        /// <summary>
        /// Gets or sets the default resource type id.
        /// </summary>
        public int DefaultResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether not allowed.
        /// </summary>
        public bool NotAllowed { get; set; }

        /// <summary>
        /// Gets or sets the default resource type.
        /// </summary>
        public virtual ResourceType DefaultResourceType { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual ICollection<File> File { get; set; }
    }
}
