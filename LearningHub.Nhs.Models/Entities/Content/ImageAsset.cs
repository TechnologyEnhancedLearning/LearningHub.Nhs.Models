// <copyright file="ImageAsset.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Content
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// Defines the <see cref="ImageAsset" />.
    /// </summary>
    public partial class ImageAsset : EntityBase
    {
        /// <summary>
        /// Gets or sets the PageSectionDetailId.
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the ImageFileId.
        /// </summary>
        public int? ImageFileId { get; set; }

        /// <summary>
        /// Gets or sets the AltTag.
        /// </summary>
        public string AltTag { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ImageFile.
        /// </summary>
        public virtual File ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetail.
        /// </summary>
        public virtual PageSectionDetail PageSectionDetail { get; set; }
    }
}
