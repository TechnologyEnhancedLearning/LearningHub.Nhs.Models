// <copyright file="Block.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using LearningHub.Nhs.Models.Resource.Blocks;

    /// <summary>
    /// The block.
    /// </summary>
    public class Block : EntityBase
    {
        /// <summary>
        /// Gets or sets the Block Collection Id.
        /// </summary>
        public int BlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the Block Collection.
        /// </summary>
        public virtual BlockCollection BlockCollection { get; set; }

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
        public virtual TextBlock TextBlock { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageBlock.
        /// </summary>
        public virtual WholeSlideImageBlock WholeSlideImageBlock { get; set; }

        /// <summary>
        /// Gets or sets the MediaBlock.
        /// </summary>
        public virtual MediaBlock MediaBlock { get; set; }

        /// <summary>
        /// Gets or sets the QuestionBlock.
        /// </summary>
        public virtual QuestionBlock QuestionBlock { get; set; }

        /// <summary>
        /// Gets or sets the ImageCarouselBlock.
        /// </summary>
        public virtual ImageCarouselBlock ImageCarouselBlock { get; set; }
    }
}
