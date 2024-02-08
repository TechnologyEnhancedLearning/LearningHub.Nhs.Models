namespace LearningHub.Nhs.Models.Resource.Blocks.Annotations
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="ImageAnnotationMarkViewModel" />.
    /// </summary>
    public class ImageAnnotationMarkViewModel
    {
        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        public ImageAnnotationMarkTypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets the Mark Shape Data (for Freehand Annotations).
        /// </summary>
        public AnnotationMarkFreehandViewModel FreehandMarkShapeData { get; set; }

        /// <summary>
        /// Gets or sets the label of the mark.
        /// </summary>
        public string MarkLabel { get; set; }
    }
}