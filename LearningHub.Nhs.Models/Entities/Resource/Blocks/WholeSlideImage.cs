// <copyright file="WholeSlideImage.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;

    /// <summary>
    /// The whole slide image.
    /// </summary>
    public class WholeSlideImage : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WholeSlideImage"/> class.
        /// </summary>
        public WholeSlideImage()
        {
            this.WholeSlideImageBlockItems = new HashSet<WholeSlideImageBlockItem>();
            this.ImageAnnotations = new HashSet<ImageAnnotation>();
        }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the File Id.
        /// </summary>
        public int? FileId { get; set; }

        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageBlockItems.
        /// </summary>
        public virtual ICollection<WholeSlideImageBlockItem> WholeSlideImageBlockItems { get; set; }

        /// <summary>
        /// Gets or sets the ImageAnnotation.
        /// </summary>
        public virtual ICollection<ImageAnnotation> ImageAnnotations { get; set; }
    }
}
