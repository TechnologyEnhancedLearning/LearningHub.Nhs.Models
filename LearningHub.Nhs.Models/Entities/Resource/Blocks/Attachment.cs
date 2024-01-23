// <copyright file="Attachment.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The attachment.
    /// </summary>
    public class Attachment : EntityBase
    {
        /// <summary>
        /// Gets or sets the FileId.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the MediaBlocks.
        /// </summary>
        public virtual ICollection<MediaBlock> MediaBlocks { get; set; }
    }
}