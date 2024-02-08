namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The media block.
    /// </summary>
    public class MediaBlock : EntityBase
    {
        /// <summary>
        /// Gets or sets the Block Id.
        /// </summary>
        public int BlockId { get; set; }

        /// <summary>
        /// Gets or sets the Block.
        /// </summary>
        public virtual Block Block { get; set; }

        /// <summary>
        /// Gets or sets the MediaType.
        /// </summary>
        public MediaType MediaType { get; set; }

        /// <summary>
        /// Gets or sets the AttachmentId.
        /// </summary>
        public int? AttachmentId { get; set; }

        /// <summary>
        /// Gets or sets the Attachment.
        /// </summary>
        public virtual Attachment Attachment { get; set; }

        /// <summary>
        /// Gets or sets the ImageId.
        /// </summary>
        public int? ImageId { get; set; }

        /// <summary>
        /// Gets or sets the Image.
        /// </summary>
        public virtual Image Image { get; set; }

        /// <summary>
        /// Gets or sets the VideoId.
        /// </summary>
        public int? VideoId { get; set; }

        /// <summary>
        /// Gets or sets the Video.
        /// </summary>
        public virtual Video Video { get; set; }
    }
}
