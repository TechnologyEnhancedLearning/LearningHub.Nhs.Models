namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The video.
    /// </summary>
    public class Video : EntityBase
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