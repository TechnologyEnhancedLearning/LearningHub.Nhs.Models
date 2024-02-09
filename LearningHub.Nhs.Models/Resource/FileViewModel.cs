namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Resource.Files;

    /// <summary>
    /// The file view model.
    /// </summary>
    public class FileViewModel
    {
        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the file size kb.
        /// </summary>
        public long FileSizeKb { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file type.
        /// </summary>
        public FileTypeViewModel FileType { get; set; }

        /// <summary>
        /// Gets or sets the file type id.
        /// </summary>
        public int FileTypeId { get; set; }

        /// <summary>
        /// Gets or sets the file chunk detail id.
        /// </summary>
        public int? FileChunkDetailId { get; set; }

        /// <summary>
        /// Gets or sets the Partial File details.
        /// </summary>
        public PartialFileViewModel PartialFile { get; set; }

        /// <summary>
        /// Gets or sets the Video File details.
        /// </summary>
        public VideoFileViewModel VideoFile { get; set; }

        /// <summary>
        /// Gets or sets the Whole Slide Image File details.
        /// </summary>
        public WholeSlideImageFileViewModel WholeSlideImageFile { get; set; }
    }
}
