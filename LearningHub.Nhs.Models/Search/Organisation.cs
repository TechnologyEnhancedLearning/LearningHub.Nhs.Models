namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The organisation element.
    /// </summary>
    public class Organisation
    {
        /// <summary>
        /// Gets or sets the logo url.
        /// </summary>
        [JsonProperty("logo_url")]
        public string Logo_url { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
