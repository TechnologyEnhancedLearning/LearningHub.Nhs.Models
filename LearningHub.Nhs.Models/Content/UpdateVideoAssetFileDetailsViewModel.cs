// <copyright file="UpdateVideoAssetFileDetailsViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// Defines the <see cref="UpdateVideoAssetFileDetailsViewModel" />.
    /// </summary>
    public class UpdateVideoAssetFileDetailsViewModel
    {
        /// <summary>
        /// Gets or sets the PageSectionDetailId.
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the VideoFileId.
        /// </summary>
        public int VideoFileId { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the AmendUserId.
        /// </summary>
        public int? AmendUserId { get; set; }
    }
}
