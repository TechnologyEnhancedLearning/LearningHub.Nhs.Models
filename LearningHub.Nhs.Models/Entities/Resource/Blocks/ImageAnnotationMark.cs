// <copyright file="ImageAnnotationMark.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The Whole Slide Image annotation.
    /// </summary>
    public class ImageAnnotationMark : EntityBase
    {
        /// <summary>
        /// Gets or sets the Whole Slide Image Annotation ID.
        /// </summary>
        public int ImageAnnotationId { get; set; }

        /// <summary>
        /// Gets or sets the Whole Slide Image Annotation.
        /// </summary>
        public virtual ImageAnnotation ImageAnnotation { get; set; }

        /// <summary>
        /// Gets or sets the Type.
        /// </summary>
        public ImageAnnotationMarkTypeEnum Type { get; set; }

        /// <summary>
        /// Gets or sets the Data Points.
        /// </summary>
        public string MarkShapeData { get; set; }

        /// <summary>
        /// Gets or sets the label of the mark.
        /// </summary>
        public string MarkLabel { get; set; }
    }
}