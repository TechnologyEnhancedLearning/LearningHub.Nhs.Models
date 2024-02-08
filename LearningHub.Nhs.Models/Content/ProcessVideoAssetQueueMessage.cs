namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// Defines the <see cref="ProcessVideoAssetQueueMessage" />.
    /// </summary>
    public class ProcessVideoAssetQueueMessage
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
    }
}
