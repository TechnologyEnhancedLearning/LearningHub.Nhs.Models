// <copyright file="FileUpdateRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// The file update request view model.
    /// </summary>
    public class FileUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int? AmendUserId { get; set; }
    }
}
