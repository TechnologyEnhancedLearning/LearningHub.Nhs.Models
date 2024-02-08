namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    /// <summary>
    /// The whole slide image block item.
    /// </summary>
    public class WholeSlideImageBlockItem : EntityBase
    {
        /// <summary>
        /// Gets or sets the WholeSlideImageBlockId.
        /// </summary>
        public int WholeSlideImageBlockId { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageBlock.
        /// </summary>
        public virtual WholeSlideImageBlock WholeSlideImageBlock { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageId.
        /// </summary>
        public int? WholeSlideImageId { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImage.
        /// </summary>
        public virtual WholeSlideImage WholeSlideImage { get; set; }

        /// <summary>
        /// Gets or sets the PlaceholderText.
        /// </summary>
        public string PlaceholderText { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        public int Order { get; set; }
    }
}