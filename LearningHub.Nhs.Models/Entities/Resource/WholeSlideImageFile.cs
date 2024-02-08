namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Resource.Files;

    /// <summary>
    /// The Partial File.
    /// </summary>
    public class WholeSlideImageFile : EntityBase
    {
        /// <summary>
        /// Gets or sets the File ID.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the status of the file.
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
