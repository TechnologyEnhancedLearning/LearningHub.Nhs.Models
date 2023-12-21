// <copyright file="MediaVideoViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Blocks
{
    using LearningHub.Nhs.Models.Resource.Files;

    /// <summary>
    /// The video.
    /// </summary>
    public class MediaVideoViewModel
    {
        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the VideoFile.
        /// </summary>
        public VideoFileViewModel VideoFile { get; set; }
    }
}