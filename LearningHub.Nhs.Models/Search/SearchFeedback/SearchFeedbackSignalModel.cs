namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback signal model.
    /// </summary>
    public class SearchFeedbackSignalModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFeedbackSignalModel"/> class.
        /// </summary>
        public SearchFeedbackSignalModel()
        {
            this.Stats = new SearchFeedbackStatsModel();
            this.ProfileSignature = new SearchFeedbackProfileSignatureModel();
        }

        /// <summary>
        /// Gets or sets the search stats.
        /// </summary>
        [JsonProperty(PropertyName = "stats")]
        public SearchFeedbackStatsModel Stats { get; set; }

        /// <summary>
        /// Gets or sets the search id.
        /// </summary>
        [JsonProperty(PropertyName = "searchId")]
        public string SearchId { get; set; }

        /// <summary>
        /// Gets or sets the profile signature.
        /// </summary>
        [JsonProperty(PropertyName = "profileSignature")]
        public SearchFeedbackProfileSignatureModel ProfileSignature { get; set; }

        /// <summary>
        /// Gets or sets the user query.
        /// </summary>
        [JsonProperty(PropertyName = "userQuery")]
        public string UserQuery { get; set; }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public string Query { get; set; }

        /// <summary>
        /// Gets or sets the time of search.
        /// </summary>
        [JsonProperty(PropertyName = "timeOfSearch")]
        public long TimeOfSearch { get; set; }
    }
}