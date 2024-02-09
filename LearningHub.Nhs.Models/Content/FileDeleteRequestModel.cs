namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The file delete request view model.
    /// </summary>
    public class FileDeleteRequestModel
    {
        /// <summary>
        /// Gets or sets the resource type..
        /// </summary>
        public ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the page section detail id..
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the file id..
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the attached file type..
        /// </summary>
        public AttachedFileTypeEnum AttachedFileType { get; set; }
    }
}
