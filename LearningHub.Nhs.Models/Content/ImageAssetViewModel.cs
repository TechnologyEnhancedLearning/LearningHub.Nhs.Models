// <copyright file="ImageAssetViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// Defines the <see cref="ImageAssetViewModel" />.
    /// </summary>
    public class ImageAssetViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

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
        public FileViewModel ImageFile { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetail.
        /// </summary>
        public PageSectionDetailViewModel PageSectionDetail { get; set; }
    }
}
