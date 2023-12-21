// <copyright file="PageImageSectionUpdateViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// The PageImageSectionUpdateViewModel.
    /// </summary>
    public class PageImageSectionUpdateViewModel : PageSectionDetailUpdateViewModel
    {
        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        public string ImageFileName { get; set; }

        /// <summary>
        /// Gets or sets FilePath.
        /// </summary>
        public string ImageFilePath { get; set; }

        /// <summary>
        /// Gets or sets FilePath.
        /// </summary>
        public int ImageFileSize { get; set; }

        /// <summary>
        /// Gets or sets ImageAlt.
        /// </summary>
        public string ImageAlt { get; set; }
    }
}