namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Resource.Files;

    /// <summary>
    /// The VideoFile.
    /// </summary>
    public class VideoFile : EntityBase
    {
        /// <summary>
        /// Gets or sets the File ID.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the Closed Captions ID.
        /// </summary>
        public int? CaptionsFileId { get; set; }

        /// <summary>
        /// Gets or sets the Closed Captions file.
        /// </summary>
        public virtual CaptionsFile CaptionsFile { get; set; }

        /// <summary>
        /// Gets or sets the Transcript ID.
        /// </summary>
        public int? TranscriptFileId { get; set; }

        /// <summary>
        /// Gets or sets the Transcript file.
        /// </summary>
        public virtual TranscriptFile TranscriptFile { get; set; }

        /// <summary>
        /// Gets or sets the status of the file.
        /// </summary>
        public VideoFileStatus Status { get; set; }

        /// <summary>
        /// Gets or sets any error message received during processing the file.
        /// </summary>
        public string ProcessingErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the file path of the output of the Asset in Azure containing this video content.
        /// </summary>
        public string AzureAssetOutputFilePath { get; set; }

        /// <summary>
        /// Gets or sets the LocatorUri.
        /// </summary>
        public string LocatorUri { get; set; }

        /// <summary>
        /// Gets or sets the EncodeJobName.
        /// </summary>
        public string EncodeJobName { get; set; }

        /// <summary>
        /// Gets or sets the DurationInMilliseconds.
        /// </summary>
        public int DurationInMilliseconds { get; set; }
    }
}