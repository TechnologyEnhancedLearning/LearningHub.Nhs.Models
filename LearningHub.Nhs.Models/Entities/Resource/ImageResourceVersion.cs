// <copyright file="ImageResourceVersion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The image resource version.
    /// </summary>
    public partial class ImageResourceVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageResourceVersion"/> class.
        /// </summary>
        public ImageResourceVersion()
        {
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the image file id.
        /// </summary>
        public int ImageFileId { get; set; }

        /// <summary>
        /// Gets or sets the alt tag.
        /// </summary>
        public string AltTag { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
