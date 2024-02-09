namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// Defines the <see cref="UpdateVideoAssetStateViewModel" />.
    /// </summary>
    public class UpdateVideoAssetStateViewModel
    {
        /// <summary>
        /// Gets or sets the PageSectionDetailId.
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionStatus.
        /// </summary>
        public PageSectionStatus PageSectionStatus { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }
    }
}
