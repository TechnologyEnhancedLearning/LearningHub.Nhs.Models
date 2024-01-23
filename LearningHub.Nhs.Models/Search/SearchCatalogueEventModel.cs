// <copyright file="SearchCatalogueEventModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    /// <summary>
    /// The catalogue search event model.
    /// </summary>
    public class SearchCatalogueEventModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        public string SearchText { get; set; }

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
    }
}