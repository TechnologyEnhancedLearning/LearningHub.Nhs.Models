namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The Whole Slide Image annotation.
    /// </summary>
    public class ImageAnnotation : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImageAnnotation"/> class.
        /// </summary>
        public ImageAnnotation()
        {
            this.ImageAnnotationMarks = new HashSet<ImageAnnotationMark>();
        }

        /// <summary>
        /// Gets or sets the Whole Slide Image ID.
        /// </summary>
        public int? WholeSlideImageId { get; set; }

        /// <summary>
        /// Gets or sets the Whole Slide Image.
        /// </summary>
        public virtual WholeSlideImage WholeSlideImage { get; set; }

        /// <summary>
        /// Gets or sets the Image ID.
        /// </summary>
        public int? ImageId { get; set; }

        /// <summary>
        /// Gets or sets the Image.
        /// </summary>
        public virtual Image Image { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the Label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the X-Coordinate for the location of the pin associated with this annotation.
        /// </summary>
        public decimal PinXCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Y-Coordinate for the location of the pin associated with this annotation.
        /// </summary>
        public decimal PinYCoordinate { get; set; }

        /// <summary>
        /// Gets or sets the Colour.
        /// </summary>
        public ImageAnnotationColourEnum Colour { get; set; }

        /// <summary>
        /// Gets or sets the ImageAnnotationMark.
        /// </summary>
        public virtual ICollection<ImageAnnotationMark> ImageAnnotationMarks { get; set; }
    }
}