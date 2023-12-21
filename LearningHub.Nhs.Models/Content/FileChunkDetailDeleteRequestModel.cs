// <copyright file="FileChunkDetailDeleteRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    /// <summary>
    /// The file delete request view model.
    /// </summary>
    public class FileChunkDetailDeleteRequestModel
    {
        /// <summary>
        /// Gets or sets the file chunk detail id..
        /// </summary>
        public int FileChunkDetailId { get; set; }

        /// <summary>
        /// Gets or sets the amend user id..
        /// </summary>
        public int? AmendUserId { get; set; }
    }
}
