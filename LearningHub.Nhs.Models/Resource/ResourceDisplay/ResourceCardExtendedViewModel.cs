namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System;
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// The resource card extended view model.
    /// </summary>
    public class ResourceCardExtendedViewModel : ResourceCardViewModel
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
        /// Gets or sets the last version update date.
        /// </summary>
        public DateTimeOffset LastVersionUpdateDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether show flag resource link.
        /// </summary>
        public bool ShowFlagResourceLink { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether show action panel.
        /// </summary>
        public bool ShowActionPanel { get; set; }
    }
}
