// <copyright file="PageSection.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Content
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="PageSection" />.
    /// </summary>
    public class PageSection : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageSection"/> class.
        /// </summary>
        public PageSection()
        {
            this.PageSectionDetails = new HashSet<PageSectionDetail>();
        }

        /// <summary>
        /// Gets or sets the PageId.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the Position.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsHidden.
        /// </summary>
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or sets the SectionTemplateType.
        /// </summary>
        public int SectionTemplateTypeId { get; set; }

        /// <summary>
        /// Gets or sets the Page.
        /// </summary>
        public virtual Page Page { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionDetails.
        /// </summary>
        public virtual ICollection<PageSectionDetail> PageSectionDetails { get; set; }
    }
}