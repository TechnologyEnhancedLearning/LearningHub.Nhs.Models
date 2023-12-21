// <copyright file="PageSectionDetailViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// Defines the <see cref="PageSectionDetailViewModel" />.
    /// </summary>
    public partial class PageSectionDetailViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageSectionDetailViewModel"/> class.
        /// </summary>
        public PageSectionDetailViewModel()
        {
        }

        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionId.
        /// </summary>
        public int PageSectionId { get; set; }

        /// <summary>
        /// Gets or sets the section title.
        /// </summary>
        public string SectionTitle { get; set; }

        /// <summary>
        /// Gets or sets the section title element.
        /// </summary>
        public string SectionTitleElement { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a top margin exists.
        /// </summary>
        public bool TopMargin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a bottom margin exists.
        /// </summary>
        public bool BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether a border exists.
        /// </summary>
        public bool HasBorder { get; set; }

        /// <summary>
        /// Gets or sets the BackgroundColour.
        /// </summary>
        public string BackgroundColour { get; set; }

        /// <summary>
        /// Gets or sets the TextColour.
        /// </summary>
        public string TextColour { get; set; }

        /// <summary>
        /// Gets or sets the HyperLinkColour.
        /// </summary>
        public string HyperLinkColour { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets TextBackgroundColour.
        /// </summary>
        public string TextBackgroundColour { get; set; }

        /// <summary>
        /// Gets or sets the SectionLayoutType.
        /// </summary>
        public SectionLayoutType SectionLayoutType { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionStatus.
        /// </summary>
        public PageSectionStatus PageSectionStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the draft is delete pending.
        /// </summary>
        public bool? DeletePending { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the draft is hidden.
        /// </summary>
        public bool? DraftHidden { get; set; }

        /// <summary>
        /// Gets or sets the draft position.
        /// </summary>
        public int? DraftPosition { get; set; }

        /// <summary>
        /// Gets or sets the AmendUserId.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the PageSection.
        /// </summary>
        public PageSectionViewModel PageSection { get; set; }

        /// <summary>
        /// Gets or sets the ImageAsset.
        /// </summary>
        public ImageAssetViewModel ImageAsset { get; set; }

        /// <summary>
        /// Gets or sets the VideoAssetts.
        /// </summary>
        public VideoAssetViewModel VideoAsset { get; set; }
    }
}
