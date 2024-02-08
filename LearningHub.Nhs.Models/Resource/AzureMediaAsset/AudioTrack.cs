namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    /// <summary>
    /// AudioTrack.
    /// </summary>
    public class AudioTrack
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Codec.
        /// </summary>
        public string Codec { get; set; }

        /// <summary>
        /// Gets or sets the Language.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the Channels.
        /// </summary>
        public long Channels { get; set; }

        /// <summary>
        /// Gets or sets the SamplingRate.
        /// </summary>
        public long SamplingRate { get; set; }

        /// <summary>
        /// Gets or sets the Bitrate.
        /// </summary>
        public long Bitrate { get; set; }
    }
}
