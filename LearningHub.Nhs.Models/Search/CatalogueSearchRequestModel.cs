namespace LearningHub.Nhs.Models.Search
{
    using System;

    /// <summary>
    /// The catalogue search request model.
    /// </summary>
    public class CatalogueSearchRequestModel
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
        /// Gets or sets the group id.
        /// </summary>
        public Guid GroupId { get; set; }
    }
}