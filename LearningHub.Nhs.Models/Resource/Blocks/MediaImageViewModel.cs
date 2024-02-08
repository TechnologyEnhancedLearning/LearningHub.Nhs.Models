namespace LearningHub.Nhs.Models.Resource.Blocks
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Resource.Blocks.Annotations;

    /// <summary>
    /// Defines the <see cref="MediaImageViewModel" />.
    /// </summary>
    public class MediaImageViewModel
    {
        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the AltText.
        /// </summary>
        public string AltText { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Annotations.
        /// </summary>
        public List<ImageAnnotationViewModel> Annotations { get; set; }
    }
}