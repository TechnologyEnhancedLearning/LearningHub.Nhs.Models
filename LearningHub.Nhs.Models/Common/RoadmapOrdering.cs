// <copyright file="RoadmapOrdering.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// The RoadmapOrdering.
    /// </summary>
    public class RoadmapOrdering
    {
        /// <summary>
        /// Gets or sets the ordered ids.
        /// </summary>
        public List<int> OrderedIds { get; set; }

        /// <summary>
        /// Gets or sets the roadmap type.
        /// </summary>
        public int RoadmapType { get; set; }
    }
}
