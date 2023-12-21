// <copyright file="ImageAnnotationViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Blocks.Annotations
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="ImageAnnotationViewModel" />.
    /// </summary>
    public class ImageAnnotationViewModel
    {
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
        public List<ImageAnnotationMarkViewModel> ImageAnnotationMarks { get; set; }
    }
}