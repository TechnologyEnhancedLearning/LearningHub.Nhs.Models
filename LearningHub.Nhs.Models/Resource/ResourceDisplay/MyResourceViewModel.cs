// <copyright file="MyResourceViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System.Collections.Generic;

    /// <summary>
    /// The my resource view model.
    /// </summary>
    public class MyResourceViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyResourceViewModel"/> class.
        /// </summary>
        public MyResourceViewModel()
        {
            this.Cards = new List<ResourceCardViewModel>();
        }

        /// <summary>
        /// Gets or sets the cards.
        /// </summary>
        public List<ResourceCardViewModel> Cards { get; set; }
    }
}
