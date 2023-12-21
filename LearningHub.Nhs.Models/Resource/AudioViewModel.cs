// <copyright file="AudioViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The audio view model.
    /// </summary>
    public class AudioViewModel
    {
        /// <summary>
        /// Gets or sets the  id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the transcript file id.
        /// </summary>
        public int TranscriptFileId { get; set; }

        /// <summary>
        /// Gets or sets the transcript file.
        /// </summary>
        public FileViewModel TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the resource azure media asset id.
        /// </summary>
        public int ResourceAzureMediaAssetId { get; set; }

        /// <summary>
        /// Gets or sets the resource azure media asset.
        /// </summary>
        public ResourceAzureMediaAssetViewModel ResourceAzureMediaAsset { get; set; }

        /// <summary>
        /// Gets or sets the duration in millseconds.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }
    }
}
