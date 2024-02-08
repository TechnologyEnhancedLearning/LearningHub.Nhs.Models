namespace LearningHub.Nhs.Models.Content
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// Defines the <see cref="PageViewModel" />.
    /// </summary>
    public class PageViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the AmendUserId.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the PageStatus.
        /// </summary>
        public PageStatus PageStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether HasHiddenSections.
        /// </summary>
        public bool HasHiddenSections { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CanPreview.
        /// </summary>
        public bool CanPreview { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CanDiscard.
        /// </summary>
        public bool CanDiscard { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether CanPublish.
        /// </summary>
        public bool CanPublish { get; set; }

        /// <summary>
        /// Gets or sets the PreviewUrl.
        /// </summary>
        public string PreviewUrl { get; set; }

        /// <summary>
        /// Gets or sets the PageSections.
        /// </summary>
        public List<PageSectionViewModel> PageSections { get; set; }
    }
}
