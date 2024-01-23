// <copyright file="SearchRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System;

    /// <summary>
    /// The search request model.
    /// </summary>
    public class SearchRequestModel
    {
        /// <summary>
        /// Gets or sets the search id.
        /// </summary>
        public int SearchId { get; set; }

        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        public string SearchText { get; set; }

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

        /// <summary>
        /// Gets or sets the sort column.
        /// </summary>
        public string SortColumn { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the  total number of hits.
        /// </summary>
        public int TotalNumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the page index.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the search event type enum.
        /// </summary>
        public Enums.EventTypeEnum EventTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the catalogue Id.
        /// </summary>
        public int? CatalogueId { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        public Guid GroupId { get; set; }
    }
}