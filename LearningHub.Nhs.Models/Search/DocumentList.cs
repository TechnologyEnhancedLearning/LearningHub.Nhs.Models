namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Document List element.
    /// </summary>
    public class Documentlist
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the number of hits.
        /// </summary>
        [JsonProperty("numberOfHits")]
        public int NumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the documents.
        /// </summary>
        [JsonProperty("documents")]
        public Document[] Documents { get; set; }

        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        [JsonProperty("pagination")]
        public object Pagination { get; set; }

        /// <summary>
        /// Gets or sets the sort options.
        /// </summary>
        [JsonProperty("sortOptions")]
        public object[] SortOptions { get; set; }
    }
}
