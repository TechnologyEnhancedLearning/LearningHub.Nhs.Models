// <copyright file="FileChunkDetailViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The file create request view model.
    /// </summary>
    public class FileChunkDetailViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

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
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }
    }
}
