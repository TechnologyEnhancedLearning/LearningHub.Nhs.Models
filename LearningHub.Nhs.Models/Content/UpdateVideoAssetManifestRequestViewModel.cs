// <copyright file="UpdateVideoAssetManifestRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// Defines the <see cref="UpdateVideoAssetManifestRequestViewModel" />.
    /// </summary>
    public class UpdateVideoAssetManifestRequestViewModel
    {
        /// <summary>
        /// Gets or sets the PageSectionDetailId.
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssetFileId.
        /// </summary>
        public int VideoAssetFileId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the AzureMediaAssetId.
        /// </summary>
        public int AzureMediaAssetId { get; set; }

        /// <summary>
        /// Gets or sets the DurationInMilliseconds.
        /// </summary>
        public int DurationInMilliseconds { get; set; }
    }
}
