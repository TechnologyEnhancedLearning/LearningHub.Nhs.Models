// <copyright file="SearchCatalogueViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System.Collections.Generic;

    /// <summary>
    /// The Search Catalogue View Model.
    /// </summary>
    public class SearchCatalogueViewModel : SearchViewModel
    {
        /// <summary>
        /// Gets or sets the Document Model.
        /// </summary>
        public new List<CatalogueDocument> DocumentModel { get; set; }
    }
}
