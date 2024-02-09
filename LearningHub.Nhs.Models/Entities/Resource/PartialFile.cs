namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The Partial File.
    /// </summary>
    public class PartialFile : EntityBase
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
        /// Gets or sets the Total expected size of the file.
        /// </summary>
        public long TotalSize { get; set; }
    }
}
