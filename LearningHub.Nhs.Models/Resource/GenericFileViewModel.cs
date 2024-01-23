// <copyright file="GenericFileViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The generic file view model.
    /// </summary>
    public class GenericFileViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public FileViewModel File { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether scorm aicc content.
        /// </summary>
        public bool ScormAiccContent { get; set; }

        /// <summary>
        /// Gets or sets the authored year.
        /// </summary>
        public int? AuthoredYear { get; set; }

        /// <summary>
        /// Gets or sets the authored month.
        /// </summary>
        public int? AuthoredMonth { get; set; }

        /// <summary>
        /// Gets or sets the authored day of month.
        /// </summary>
        public int? AuthoredDayOfMonth { get; set; }
    }
}
