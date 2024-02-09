namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// Defines the <see cref="VideoAssetViewModel" />.
    /// </summary>
    public class VideoAssetViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

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
        /// Gets or sets the AmendUserId.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the AzureMediaAsset.
        /// </summary>
        public ResourceAzureMediaAssetViewModel AzureMediaAsset { get; set; }

        /// <summary>
        /// Gets or sets the ClosedCaptionsFile.
        /// </summary>
        public FileViewModel ClosedCaptionsFile { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetail.
        /// </summary>
        public PageSectionDetailViewModel PageSectionDetail { get; set; }

        /// <summary>
        /// Gets or sets the ThumbnailImageFile.
        /// </summary>
        public FileViewModel ThumbnailImageFile { get; set; }

        /// <summary>
        /// Gets or sets the TranscriptFile.
        /// </summary>
        public FileViewModel TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the VideoFile.
        /// </summary>
        public FileViewModel VideoFile { get; set; }
    }
}
