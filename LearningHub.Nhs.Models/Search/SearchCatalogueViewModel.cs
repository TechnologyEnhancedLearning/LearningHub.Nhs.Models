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
