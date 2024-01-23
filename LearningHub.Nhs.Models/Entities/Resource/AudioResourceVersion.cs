// <copyright file="AudioResourceVersion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The audio resource version.
    /// </summary>
    public partial class AudioResourceVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AudioResourceVersion"/> class.
        /// </summary>
        public AudioResourceVersion()
        {
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the audio file id.
        /// </summary>
        public int AudioFileId { get; set; }

        /// <summary>
        /// Gets or sets the transcript file id.
        /// </summary>
        public int? TranscriptFileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the transcript file.
        /// </summary>
        public virtual File TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the resource azure media asset id.
        /// </summary>
        public int? ResourceAzureMediaAssetId { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the duration in millseconds.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }

        /// <summary>
        ///  Gets or sets the resource azure media asset.
        /// </summary>
        public virtual ResourceAzureMediaAsset ResourceAzureMediaAsset { get; set; }
    }
}
