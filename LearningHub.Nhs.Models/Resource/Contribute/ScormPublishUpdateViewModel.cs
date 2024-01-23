// <copyright file="ScormPublishUpdateViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The scorm publish update view model.
    /// </summary>
    public class ScormPublishUpdateViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the zip file id.
        /// </summary>
        public string ContentFilePath { get; set; }

        /// <summary>
        /// Gets or sets the development id.
        /// </summary>
        public string DevelopmentId { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }
    }
}
