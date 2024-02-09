namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The file create request view model.
    /// </summary>
    public class FileCreateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the page section detail id..
        /// </summary>
        public int PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets the file type id..
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the file name..
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the file path..
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file size..
        /// </summary>
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or sets the replaced file id..
        /// </summary>
        public int ReplacedFileId { get; set; }

        /// <summary>
        /// Gets or sets the attahed file type..
        /// </summary>
        public AttachedFileTypeEnum AttachedFileType { get; set; }

        /// <summary>
        /// Gets or sets the file chunk detail id..
        /// </summary>
        public int? FileChunkDetailId { get; set; }
    }
}
