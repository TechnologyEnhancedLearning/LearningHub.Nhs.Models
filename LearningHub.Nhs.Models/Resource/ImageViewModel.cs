// <copyright file="ImageViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The image view model.
    /// </summary>
    public class ImageViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the image file id.
        /// </summary>
        public int ImageFileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the alt tag.
        /// </summary>
        public string AltTag { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
