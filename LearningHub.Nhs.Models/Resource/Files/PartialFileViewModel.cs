// <copyright file="PartialFileViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Files
{
    /// <summary>
    /// Defines the <see cref="PartialFileViewModel" />.
    /// </summary>
    public class PartialFileViewModel
    {
        /// <summary>
        /// Gets or sets the File ID.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the File Name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the File Path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the Post-processing Options.
        /// </summary>
        public PartialFilePostProcessingOptions PostProcessingOptions { get; set; }

        /// <summary>
        /// Gets or sets the Total File Size.
        /// </summary>
        public long TotalFileSize { get; set; }

        /// <summary>
        /// Gets or sets the Uploaded File Size (the number of bytes currently uploaded).
        /// </summary>
        public long UploadedFileSize { get; set; }
    }
}