namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The Scorm file view model.
    /// </summary>
    public class ScormFileViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id..
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file id..
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the File.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the EsrLinkType.
        /// </summary>
        public EsrLinkType EsrLinkType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether file can be downloaded..
        /// </summary>
        public bool CanDownload { get; set; }
    }
}