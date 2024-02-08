namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    using System.Collections.Generic;

    /// <summary>
    /// AssetFile.
    /// </summary>
    public class AssetFile
    {
        /// <summary>
        /// Gets or sets the Sources.
        /// </summary>
        public List<Source> Sources { get; set; }

        /// <summary>
        /// Gets or sets the VideoTracks.
        /// </summary>
        public List<VideoTrack> VideoTracks { get; set; }

        /// <summary>
        /// Gets or sets the AudioTracks.
        /// </summary>
        public List<AudioTrack> AudioTracks { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Size.
        /// </summary>
        public long Size { get; set; }

        /// <summary>
        /// Gets or sets the Duration.
        /// </summary>
        public string Duration { get; set; }
    }
}
