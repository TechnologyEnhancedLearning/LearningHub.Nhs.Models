namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// Defines the <see cref="PageSectionViewModel" />.
    /// </summary>
    public class PageSectionViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the PageId.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsHidden.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or sets the SectionTemplateType.
        /// </summary>
        public SectionTemplateType SectionTemplateType { get; set; }

        /// <summary>
        /// Gets or sets the AmendUserId.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetail.
        /// </summary>
        public PageSectionDetailViewModel PageSectionDetail { get; set; }
    }
}
