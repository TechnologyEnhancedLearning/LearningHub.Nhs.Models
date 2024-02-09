namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The scorm view model.
    /// </summary>
    public class ScormViewModel
    {
        /// <summary>
        /// Gets or sets the scorm resource version id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the zip file id.
        /// </summary>
        public int? FileId { get; set; }

        /// <summary>
        /// Gets or sets the zip file id.
        /// </summary>
        public string ContentFilePath { get; set; }

        /// <summary>
        /// Gets or sets the development id.
        /// </summary>
        public string DevelopmentId { get; set; }

        /// <summary>
        /// Gets or sets the EsrLinkType.
        /// </summary>
        public EsrLinkType EsrLinkType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether file can be downloaded.
        /// </summary>
        public bool CanDownload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to use the use default popup window size.
        /// </summary>
        public bool UseDefaultPopupWindowSize { get; set; }

        /// <summary>
        /// Gets or sets the popup width.
        /// </summary>
        public int PopupWidth { get; set; }

        /// <summary>
        /// Gets or sets the popup height.
        /// </summary>
        public int PopupHeight { get; set; }

        /// <summary>
        /// Gets or sets the hosted content url.
        /// </summary>
        public string HostedContentUrl { get; set; }

        /// <summary>
        /// Gets or sets the scorm manifest.
        /// </summary>
        public ScormManifestViewModel ScormManifest { get; set; }

        /// <summary>
        /// Gets or sets the zip file.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets the FullHistoricUrl.
        /// </summary>
        public string FullHistoricUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets a value clear suspend data.
        /// </summary>
        public bool ClearSuspendData { get; set; }
    }
}
