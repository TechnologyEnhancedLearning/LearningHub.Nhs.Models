// <copyright file="AnnotationMarkFreehandViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Blocks.Annotations
{
    /// <summary>
    /// Defines the <see cref="AnnotationMarkFreehandViewModel" />.
    /// </summary>
    public class AnnotationMarkFreehandViewModel
    {
        /// <summary>
        /// Gets or sets the Data Points.
        /// </summary>
        public PathCoordinatesViewModel[] PathCoordinates { get; set; }
    }
}