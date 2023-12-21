// <copyright file="RoadMapResponseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.RoadMap
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="RoadMapResponseViewModel" />.
    /// </summary>
    public class RoadMapResponseViewModel
    {
        /// <summary>
        /// Gets or sets the TotalRecords.
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets the RoadMapItems.
        /// </summary>
        public List<RoadMapViewModel> RoadMapItems { get; set; }
    }
}
