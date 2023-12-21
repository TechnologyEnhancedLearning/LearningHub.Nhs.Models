// <copyright file="SearchEventModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    /// <summary>
    /// The search event model.
    /// </summary>
    public class SearchEventModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the sort column.
        /// </summary>
        public string SortColumn { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the total number of hits.
        /// </summary>
        public int TotalNumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the page index.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the items viewed.
        /// </summary>
        public int ItemsViewed { get; set; }

        /// <summary>
        /// Gets or sets the filter text.
        /// </summary>
        public string FilterText { get; set; }

        /// <summary>
        /// Gets or sets the resource access level filter text.
        /// </summary>
        public string ResourceAccessLevelFilterText { get; set; }

        /// <summary>
        /// Gets or sets the provider filter text.
        /// </summary>
        public string ProviderFilterText { get; set; }
    }
}