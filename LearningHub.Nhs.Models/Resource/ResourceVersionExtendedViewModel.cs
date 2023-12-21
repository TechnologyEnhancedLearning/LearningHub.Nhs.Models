// <copyright file="ResourceVersionExtendedViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The resource version extended view model.
    /// </summary>
    public class ResourceVersionExtendedViewModel : ResourceVersionViewModel
    {
        /// <summary>
        /// Gets or sets the equipment details.
        /// </summary>
        public EquipmentViewModel EquipmentDetails { get; set; }

        /// <summary>
        /// Gets or sets the weblink details.
        /// </summary>
        public WebLinkViewModel WebLinkDetails { get; set; }

        /// <summary>
        /// Gets or sets the embed code details.
        /// </summary>
        public EmbedCodeViewModel EmbedCodeDetails { get; set; }

        /// <summary>
        /// Gets or sets the generic file details.
        /// </summary>
        public GenericFileViewModel GenericFileDetails { get; set; }

        /// <summary>
        /// Gets or sets the image details.
        /// </summary>
        public ImageViewModel ImageDetails { get; set; }

        /// <summary>
        /// Gets or sets the article details.
        /// </summary>
        public ArticleViewModel ArticleDetails { get; set; }

        /// <summary>
        /// Gets or sets the video details.
        /// </summary>
        public VideoViewModel VideoDetails { get; set; }

        /// <summary>
        /// Gets or sets the audio details.
        /// </summary>
        public AudioViewModel AudioDetails { get; set; }

        /// <summary>
        /// Gets or sets the scorm details.
        /// </summary>
        public ScormViewModel ScormDetails { get; set; }

        /// <summary>
        /// Gets or sets the scorm file details.
        /// </summary>
        public ScormFileViewModel ScormFileDetails { get; set; }

        /// <summary>
        /// Gets or sets the case details.
        /// </summary>
        public CaseViewModel CaseDetails { get; set; }

        /// <summary>
        /// Gets or sets the case details.
        /// </summary>
        public AssessmentViewModel AssessmentDetails { get; set; }
    }
}
