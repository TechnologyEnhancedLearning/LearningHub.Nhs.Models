namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback payload model.
    /// </summary>
    public class SearchFeedbackPayloadModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFeedbackPayloadModel"/> class.
        /// </summary>
        public SearchFeedbackPayloadModel()
        {
            this.SearchSignal = new SearchFeedbackSignalModel();
        }

        /// <summary>
        /// Gets or sets the search action.
        /// </summary>
        [JsonProperty(PropertyName = "searchSignal")]
        public SearchFeedbackSignalModel SearchSignal { get; set; }

        /// <summary>
        /// Gets or sets the hit number.
        /// </summary>
        [JsonProperty(PropertyName = "hitNumber")]
        public int HitNumber { get; set; }

        /// <summary>
        /// Gets or sets the time of click.
        /// </summary>
        [JsonProperty(PropertyName = "timeOfClick")]
        public long TimeOfClick { get; set; }

        /// <summary>
        /// Gets or sets the click target url.
        /// </summary>
        [JsonProperty(PropertyName = "clickTargetUrl")]
        public string ClickTargetUrl { get; set; }
    }
}