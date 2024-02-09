namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The whole slide image block.
    /// </summary>
    public class WholeSlideImageBlock : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WholeSlideImageBlock"/> class.
        /// </summary>
        public WholeSlideImageBlock()
        {
            this.WholeSlideImageBlockItems = new HashSet<WholeSlideImageBlockItem>();
        }

        /// <summary>
        /// Gets or sets the Block Id.
        /// </summary>
        public int BlockId { get; set; }

        /// <summary>
        /// Gets or sets the Block.
        /// </summary>
        public virtual Block Block { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageBlockItems.
        /// </summary>
        public virtual ICollection<WholeSlideImageBlockItem> WholeSlideImageBlockItems { get; set; }
    }
}
