// <copyright file="MyContributionsViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System.Collections.Generic;
    using System.Linq;

    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The my contributions view model.
    /// </summary>
    public class MyContributionsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyContributionsViewModel"/> class.
        /// </summary>
        public MyContributionsViewModel()
        {
            this.Cards = new List<ResourceCardViewModel>();
        }

        /// <summary>
        /// Gets or sets the cards.
        /// </summary>
        public List<ResourceCardViewModel> Cards { get; set; }

        /// <summary>
        /// Gets the action required count.
        /// </summary>
        public int ActionRequiredCount
        {
            get
            {
                return this.Cards.Count(c => c.ActionRequired);
            }
        }

        /// <summary>
        /// Gets the draft count.
        /// </summary>
        public int DraftCount
        {
            get
            {
                return this.Cards.Count(c => c.VersionStatusEnum == VersionStatusEnum.Draft);
            }
        }

        /// <summary>
        /// Gets the published count.
        /// </summary>
        public int PublishedCount
        {
            get
            {
                return this.Cards.Count(c => c.VersionStatusEnum == VersionStatusEnum.Published);
            }
        }

        /// <summary>
        /// Gets the unpublished count.
        /// </summary>
        public int UnpublishedCount
        {
            get
            {
                return this.Cards.Count(c => c.VersionStatusEnum == VersionStatusEnum.Unpublished);
            }
        }
    }
}
