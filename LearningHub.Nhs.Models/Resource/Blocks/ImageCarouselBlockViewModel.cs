namespace LearningHub.Nhs.Models.Resource.Blocks
{
    /// <summary>
    /// Defines the <see cref="ImageCarouselBlockViewModel" />.
    /// </summary>
    public class ImageCarouselBlockViewModel
    {
        /// <summary>
        /// Gets or sets the Block.
        /// </summary>
        public virtual BlockViewModel Block { get; set; }

        /// <summary>
        /// Gets or sets the block collection containing the images. Should only contain Image type Media Blocks.
        /// </summary>
        public virtual BlockCollectionViewModel ImageBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the description of the image carousel block.
        /// </summary>
        public virtual string Description { get; set; }
    }
}