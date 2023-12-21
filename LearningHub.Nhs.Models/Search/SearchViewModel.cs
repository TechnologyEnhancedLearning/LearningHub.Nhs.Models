// <copyright file="SearchViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Catalogue;
    using LearningHub.Nhs.Models.Search.SearchFeedback;

    /// <summary>
    /// The search view model.
    /// </summary>
    public class SearchViewModel
    {
        /// <summary>
        /// Gets or sets the search id.
        /// </summary>
        public int SearchId { get; set; }

        /// <summary>
        /// Gets or sets the description maximum length.
        /// </summary>
        public int DescriptionMaximumLength { get; set; }

        /// <summary>
        /// Gets or sets the search string.
        /// </summary>
        public string SearchString { get; set; }

        /// <summary>
        /// Gets or sets the hits.
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// Gets or sets the total hits.
        /// </summary>
        public int TotalHits { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets a value for the error on API flag.
        /// </summary>
        public bool ErrorOnAPI { get; set; }

        /// <summary>
        /// Gets or sets the document model.
        /// </summary>
        public List<Document> DocumentModel { get; set; }

        /// <summary>
        /// Gets or sets the sort item list.
        /// </summary>
        public ICollection<SortItemViewModel> SortItemList { get; set; }

        /// <summary>
        /// Gets or sets the selected sort item.
        /// </summary>
        public SortItemViewModel SortItemSelected { get; set; }

        /// <summary>
        /// Gets or sets the Facets.
        /// </summary>
        public Facet[] Facets { get; set; }

        /// <summary>
        /// Gets or sets the related Catalogues.
        /// </summary>
        public List<CatalogueViewModel> RelatedCatalogues { get; set; }

        /// <summary>
        /// Gets or sets the search filters.
        /// </summary>
        public List<SearchFilterModel> SearchFilters { get; set; }

        /// <summary>
        /// Gets or sets the resource access level filters.
        /// </summary>
        public List<SearchFilterModel> SearchResourceAccessLevelFilters { get; set; }

        /// <summary>
        /// Gets or sets the search provider filters.
        /// </summary>
        public List<SearchFilterModel> SearchProviderFilters { get; set; }

        /// <summary>
        /// Gets or sets the feedback.
        /// </summary>
        public SearchFeedbackModel Feedback { get; set; }
    }
}