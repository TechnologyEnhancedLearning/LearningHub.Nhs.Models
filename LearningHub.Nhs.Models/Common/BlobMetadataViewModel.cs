namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The BlobMetadataViewModel.
    /// </summary>
    public partial class BlobMetadataViewModel
    {
        /// <summary>
        /// Gets or sets the blob name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the blob size (in bytes).
        /// </summary>
        public long SizeInBytes { get; set; }
    }
}
