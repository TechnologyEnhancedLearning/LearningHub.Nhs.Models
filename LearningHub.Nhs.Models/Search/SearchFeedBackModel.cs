// <copyright file="SearchFeedBackModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System;

    /// <summary>
    /// The search feedback model.
    /// </summary>
    public class SearchFeedBackModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the feedback text.
        /// </summary>
        public string Feedback { get; set; }

        /// <summary>
        /// Gets or sets the total number of hits.
        /// </summary>
        public int TotalNumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        public Guid GroupId { get; set; }
    }
}
