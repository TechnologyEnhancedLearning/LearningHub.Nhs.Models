// <copyright file="MediaAssetInputViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The MediaAssetInputViewModel.
    /// </summary>
    public class MediaAssetInputViewModel
    {
        /// <summary>
        /// Gets or sets the video resource versionId.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource versionId.
        /// </summary>
        public int VideoResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the audio resource versionId.
        /// </summary>
        public int AudioResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource type enumeration.
        /// </summary>
        public ResourceTypeEnum ResourceTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the File name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the  userId.
        /// </summary>
        public int UserId { get; set; }
    }
}
