namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    /// <summary>
    /// The image carousel block.
    /// </summary>
    public class ImageCarouselBlock : EntityBase
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
        /// Gets or sets the id of the block collection containing the images. Should only contain Image type Media Blocks.
        /// </summary>
        public int ImageBlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the block collection containing the images. Should only contain Image type Media Blocks.
        /// </summary>
        public virtual BlockCollection ImageBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the description to be displayed on the image carousel block.
        /// </summary>
        public string Description { get; set; }
    }
}