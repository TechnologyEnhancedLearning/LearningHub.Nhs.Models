namespace LearningHub.Nhs.Models.Resource.Blocks
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="MediaBlockViewModel" />.
    /// </summary>
    public class MediaBlockViewModel
    {
        /// <summary>
        /// Gets or sets the MediaType.
        /// </summary>
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Gets or sets the Attachment.
        /// </summary>
        public AttachmentViewModel Attachment { get; set; }

        /// <summary>
        /// Gets or sets the Image.
        /// </summary>
        public MediaImageViewModel Image { get; set; }

        /// <summary>
        /// Gets or sets the Video.
        /// </summary>
        public MediaVideoViewModel Video { get; set; }
    }
}