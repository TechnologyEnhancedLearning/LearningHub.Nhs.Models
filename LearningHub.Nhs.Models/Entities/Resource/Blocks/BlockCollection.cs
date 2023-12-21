// <copyright file="BlockCollection.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The block.
    /// </summary>
    public class BlockCollection : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockCollection"/> class.
        /// </summary>
        public BlockCollection()
        {
            this.Blocks = new HashSet<Block>();
        }

        /// <summary>
        /// Gets or sets the Blocks.
        /// </summary>
        public virtual ICollection<Block> Blocks { get; set; }

        /// <summary>
        /// Gets or sets the Case Resource Version.
        /// </summary>
        public virtual CaseResourceVersion CaseResourceVersion { get; set; }
    }
}
