// <copyright file="ActiveContentViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The active content view model.
    /// </summary>
    public class ActiveContentViewModel
    {
        /// <summary>
        /// Gets or sets the scorm activity id.
        /// </summary>
        public int ScormActivityId { get; set; }

        /// <summary>
        /// Gets or sets the resource reference id.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }
    }
}
