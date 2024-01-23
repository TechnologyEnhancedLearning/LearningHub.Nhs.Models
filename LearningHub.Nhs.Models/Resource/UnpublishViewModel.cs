// <copyright file="UnpublishViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The unpublish view model.
    /// </summary>
    public class UnpublishViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to create a flag on unpublish.
        /// </summary>
        public bool SetFlag { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }
    }
}
