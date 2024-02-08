namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The scorm resource version.
    /// </summary>
    public class ScormResourceVersion : EntityBase
    {
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
        public int EsrLinkTypeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether file can be downloaded.
        /// </summary>
        public bool CanDownload { get; set; }

        /// <summary>
        /// Gets or sets the popup width.
        /// </summary>
        public int? PopupWidth { get; set; }

        /// <summary>
        /// Gets or sets the popup height.
        /// </summary>
        public int? PopupHeight { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets a value clear suspend data.
        /// </summary>
        public bool ClearSuspendData { get; set; }

        /// <summary>
        /// Gets or sets the zip file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the scorm resource version manifest.
        /// </summary>
        public virtual ScormResourceVersionManifest ScormResourceVersionManifest { get; set; }
    }
}
