namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The image.
    /// </summary>
    public class Image : EntityBase
    {
        /// <summary>
        /// Gets or sets the FileId.
        /// </summary>
        public int? FileId { get; set; }

        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the AltText.
        /// </summary>
        public string AltText { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the MediaBlocks.
        /// </summary>
        public virtual ICollection<MediaBlock> MediaBlocks { get; set; }

        /// <summary>
        /// Gets or sets the ImageAnnotation.
        /// </summary>
        public virtual ICollection<ImageAnnotation> ImageAnnotations { get; set; }
    }
}