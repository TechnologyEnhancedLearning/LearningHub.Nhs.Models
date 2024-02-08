namespace LearningHub.Nhs.Models.Search
{
    using LearningHub.Nhs.Models.Search.SearchFeedback;
    using Newtonsoft.Json;

    /// <summary>
    /// The Search Result Model Base.
    /// </summary>
    public abstract class SearchResultModelBase
    {
        /// <summary>
        /// Gets or sets the internal search Id.
        /// </summary>
        [JsonProperty("searchId")]
        public int SearchId { get; set; }

        /// <summary>
        /// Gets or sets the stats.
        /// </summary>
        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        [JsonProperty("query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets the facets.
        /// </summary>
        [JsonProperty("facets")]
        public Facet[] Facets { get; set; }

        /// <summary>
        /// Gets or sets the spell.
        /// </summary>
        [JsonProperty("spell")]
        public object Spell { get; set; }

        /// <summary>
        /// Gets or sets the quicklinks.
        /// </summary>
        [JsonProperty("quickLinks")]
        public object Quicklinks { get; set; }

        /// <summary>
        /// Gets or sets the feedback.
        /// </summary>
        [JsonProperty("feedback")]
        public SearchFeedbackModel Feedback { get; set; }

        /// <summary>
        /// Gets or sets the error messages.
        /// </summary>
        [JsonProperty("errorMessages")]
        public object[] ErrorMessages { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the error on API call.
        /// </summary>
        [JsonProperty("errorsOnAPICall")]
        public bool ErrorsOnAPICall { get; set; }
    }
}
