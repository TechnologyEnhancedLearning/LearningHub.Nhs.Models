namespace LearningHub.Nhs.Models.Search
{
    using System;

    /// <summary>
    /// The search action resource model.
    /// </summary>
    public class SearchActionResourceModel
    {
        /// <summary>
        /// Gets or sets the search text.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the resource reference id.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the total number of hits.
        /// </summary>
        public int TotalNumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the item index.
        /// </summary>
        public int ItemIndex { get; set; }

        /// <summary>
        /// Gets or sets the number of hits.
        /// </summary>
        public int NumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        public Guid GroupId { get; set; }

        /// <summary>
        /// Gets or sets the search id.
        /// </summary>
        public string SearchId { get; set; }

        /// <summary>
        /// Gets or sets the time of search.
        /// </summary>
        public long TimeOfSearch { get; set; }

        /// <summary>
        /// Gets or sets the user query.
        /// </summary>
        public string UserQuery { get; set; }

        /// <summary>
        /// Gets or sets the user query.
        /// </summary>
        public string Query { get; set; }
    }
}
