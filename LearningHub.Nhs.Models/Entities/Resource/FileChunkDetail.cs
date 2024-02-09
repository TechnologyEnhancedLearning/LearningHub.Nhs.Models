namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The file.
    /// </summary>
    public partial class FileChunkDetail : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileChunkDetail"/> class.
        /// </summary>
        public FileChunkDetail()
        {
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the chunk count.
        /// </summary>
        public int ChunkCount { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the file size.
        /// </summary>
        public int FileSizeKb { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
