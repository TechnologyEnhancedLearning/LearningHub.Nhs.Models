// <copyright file="ResourceAzureMediaAsset.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The resource azure media asset.
    /// </summary>
    public class ResourceAzureMediaAsset : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceAzureMediaAsset"/> class.
        /// </summary>
        public ResourceAzureMediaAsset()
        {
            this.VideoResourceVersion = new HashSet<VideoResourceVersion>();
            this.AudioResourceVersion = new HashSet<AudioResourceVersion>();
        }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the locator uri.
        /// </summary>
        public string LocatorUri { get; set; }

        /// <summary>
        /// Gets or sets the encodej obn name.
        /// </summary>
        public string EncodeJobName { get; set; }

        /// <summary>
        /// Gets or sets the audio resource version.
        /// </summary>
        public virtual ICollection<AudioResourceVersion> AudioResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the video resource version.
        /// </summary>
        public virtual ICollection<VideoResourceVersion> VideoResourceVersion { get; set; }
    }
}
