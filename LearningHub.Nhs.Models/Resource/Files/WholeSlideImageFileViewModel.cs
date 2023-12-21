// <copyright file="WholeSlideImageFileViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Files
{
    /// <summary>
    /// Defines the <see cref="WholeSlideImageFileViewModel" />.
    /// </summary>
    public class WholeSlideImageFileViewModel
    {
        /// <summary>
        /// Gets or sets the Status.
        /// </summary>
        public WholeSlideImageFileStatus Status { get; set; }

        /// <summary>
        /// Gets or sets any error message received during processing the file.
        /// </summary>
        public string ProcessingErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the image width (in pixels).
        /// </summary>
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the image height (in pixels).
        /// </summary>
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the Deep Zoom tile size (in pixels).
        /// </summary>
        public int? DeepZoomTileSize { get; set; }

        /// <summary>
        /// Gets or sets the Deep Zoom overlap (in pixels).
        /// </summary>
        public int? DeepZoomOverlap { get; set; }

        /// <summary>
        /// Gets or sets the number of layers.
        /// </summary>
        public int? Layers { get; set; }
    }
}