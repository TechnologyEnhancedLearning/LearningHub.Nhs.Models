// <copyright file="TextBlock.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    /// <summary>
    /// The text block.
    /// </summary>
    public class TextBlock : EntityBase
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
        /// Gets or sets the Content.
        /// </summary>
        public string Content { get; set; }
    }
}
