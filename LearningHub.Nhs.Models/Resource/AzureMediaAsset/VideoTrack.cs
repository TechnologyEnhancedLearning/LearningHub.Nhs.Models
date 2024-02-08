namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    /// <summary>
    /// VideoTrack.
    /// </summary>
    public class VideoTrack
    {
        /// <summary>
        ///  Gets or sets the Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the FourCc.
        /// </summary>
        public string FourCc { get; set; }

        /// <summary>
        /// Gets or sets the Profile.
        /// </summary>
        public string Profile { get; set; }

        /// <summary>
        ///  Gets or sets the Level.
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        ///  Gets or sets the Width.
        /// </summary>
        public long Width { get; set; }

        /// <summary>
        ///  Gets or sets the Height.
        /// </summary>
        public long Height { get; set; }

        /// <summary>
        ///  Gets or sets the DisplayAspectRatioNumerator.
        /// </summary>
        public long DisplayAspectRatioNumerator { get; set; }

        /// <summary>
        ///  Gets or sets the DisplayAspectRatioDenominator.
        /// </summary>
        public long DisplayAspectRatioDenominator { get; set; }

        /// <summary>
        ///  Gets or sets the Framerate.
        /// </summary>
        public long Framerate { get; set; }

        /// <summary>
        ///  Gets or sets the Bitrate.
        /// </summary>
        public long Bitrate { get; set; }

        /// <summary>
        ///  Gets or sets the TargetBitrate.
        /// </summary>
        public long TargetBitrate { get; set; }
    }
}
