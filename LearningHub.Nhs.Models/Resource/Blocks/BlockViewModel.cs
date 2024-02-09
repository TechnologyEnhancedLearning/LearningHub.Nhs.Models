namespace LearningHub.Nhs.Models.Resource.Blocks
{
    /// <summary>
    /// Defines the <see cref="BlockViewModel" />.
    /// </summary>
    public class BlockViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the BlockType.
        /// </summary>
        public BlockType BlockType { get; set; }

        /// <summary>
        /// Gets or sets the TextBlock.
        /// </summary>
        public TextBlockViewModel TextBlock { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageBlock.
        /// </summary>
        public WholeSlideImageBlockViewModel WholeSlideImageBlock { get; set; }

        /// <summary>
        /// Gets or sets the MediaBlock.
        /// </summary>
        public MediaBlockViewModel MediaBlock { get; set; }

        /// <summary>
        /// Gets or sets the QuestionBlock.
        /// </summary>
        public QuestionBlockViewModel QuestionBlock { get; set; }

        /// <summary>
        /// Gets or sets the ImageCarouselBlock.
        /// </summary>
        public ImageCarouselBlockViewModel ImageCarouselBlock { get; set; }
    }
}
