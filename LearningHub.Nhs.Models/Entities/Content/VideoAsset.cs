namespace LearningHub.Nhs.Models.Entities.Content
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// Defines the <see cref="VideoAsset" />.
    /// </summary>
    public class VideoAsset : EntityBase
    {
        /// <summary>
        /// Gets or sets the PageSectionDetailId.
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the VideoFileId.
        /// </summary>
        public int? VideoFileId { get; set; }

        /// <summary>
        /// Gets or sets the TranscriptFileId.
        /// </summary>
        public int? TranscriptFileId { get; set; }

        /// <summary>
        /// Gets or sets the ClosedCaptionsFileId.
        /// </summary>
        public int? ClosedCaptionsFileId { get; set; }

        /// <summary>
        /// Gets or sets the ThumbnailImageFileId.
        /// </summary>
        public int? ThumbnailImageFileId { get; set; }

        /// <summary>
        /// Gets or sets the DurationInMilliseconds.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the AzureMediaAssetId.
        /// </summary>
        public int? AzureMediaAssetId { get; set; }

        /// <summary>
        /// Gets or sets the AzureMediaAsset.
        /// </summary>
        public virtual ResourceAzureMediaAsset AzureMediaAsset { get; set; }

        /// <summary>
        /// Gets or sets the ClosedCaptionsFile.
        /// </summary>
        public virtual File ClosedCaptionsFile { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetail.
        /// </summary>
        public virtual PageSectionDetail PageSectionDetail { get; set; }

        /// <summary>
        /// Gets or sets the ThumbnailImageFile.
        /// </summary>
        public virtual File ThumbnailImageFile { get; set; }

        /// <summary>
        /// Gets or sets the TranscriptFile.
        /// </summary>
        public virtual File TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the VideoFile.
        /// </summary>
        public virtual File VideoFile { get; set; }
    }
}
