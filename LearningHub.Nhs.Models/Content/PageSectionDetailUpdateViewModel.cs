// <copyright file="PageSectionDetailUpdateViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// The PageSectionDetailUpdateViewModel.
    /// </summary>
    public class PageSectionDetailUpdateViewModel
    {
        /// <summary>
        /// Gets or sets PageSectionDetailId.
        /// </summary>
        public int? PageSectionDetailId { get; set; }

        /// <summary>
        /// Gets or sets SectionLayoutType.
        /// </summary>
        public SectionLayoutType SectionLayoutType { get; set; }

        /// <summary>
        /// Gets or sets BackgroundColour.
        /// </summary>
        public string BackgroundColour { get; set; }

        /// <summary>
        /// Gets or sets TextColour.
        /// </summary>
        public string TextColour { get; set; }

        /// <summary>
        /// Gets or sets HyperLinkColour.
        /// </summary>
        public string HyperLinkColour { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets TextBackgroundColour.
        /// </summary>
        public string TextBackgroundColour { get; set; }

        /// <summary>
        /// Gets or sets Position.
        /// </summary>
        public int Position { get; set; }

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
    }
}