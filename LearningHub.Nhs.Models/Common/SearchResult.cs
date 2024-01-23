// <copyright file="SearchResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Common
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// The search result.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the pages returned.
        /// </summary>
        public int PagesReturned { get; set; }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        public List<EntityBase> Results { get; set; }
    }
}
