namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback profile signature model.
    /// </summary>
    public class SearchFeedbackProfileSignatureModel
    {
        /// <summary>
        /// Gets or sets the application id.
        /// </summary>
        [JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Gets or sets the profile type.
        /// </summary>
        [JsonProperty(PropertyName = "profileType")]
        public string ProfileType { get; set; }

        /// <summary>
        /// Gets or sets the profile id.
        /// </summary>
        [JsonProperty(PropertyName = "profileId")]
        public string ProfileId { get; set; }
    }
}