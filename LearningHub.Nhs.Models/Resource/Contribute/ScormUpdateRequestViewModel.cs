// <copyright file="ScormUpdateRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The scorm update request view model.
    /// </summary>
    public class ScormUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether to use the use default popup window size.
        /// </summary>
        public bool UseDefaultPopupWindowSize { get; set; }

        /// <summary>
        /// Gets or sets the popup width.
        /// </summary>
        public int PopupWidth { get; set; }

        /// <summary>
        /// Gets or sets the popup height.
        /// </summary>
        public int PopupHeight { get; set; }

        /// <summary>
        /// Gets or sets the resource version id...
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the EsrLinkType.
        /// </summary>
        public EsrLinkType EsrLinkType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether file can be downloaded...
        /// </summary>
        public bool CanDownload { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets a value clear suspend data.
        /// </summary>
        public bool ClearSuspendData { get; set; }
    }
}
