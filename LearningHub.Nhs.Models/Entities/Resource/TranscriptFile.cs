namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The TranscriptFile.
    /// </summary>
    public class TranscriptFile : EntityBase
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
        /// Gets or sets the Video file.
        /// </summary>
        public virtual VideoFile VideoFile { get; set; }
    }
}