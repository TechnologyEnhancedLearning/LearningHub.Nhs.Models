namespace LearningHub.Nhs.Models.Resource.Blocks
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Resource.Blocks.Annotations;

    /// <summary>
    /// Defines the <see cref="WholeSlideImageViewModel" />.
    /// </summary>
    public class WholeSlideImageViewModel
    {
        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageFile.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the Annotations.
        /// </summary>
        public List<ImageAnnotationViewModel> Annotations { get; set; }
    }
}
