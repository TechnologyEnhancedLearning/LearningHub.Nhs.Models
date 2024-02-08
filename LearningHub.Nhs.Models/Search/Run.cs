namespace LearningHub.Nhs.Models.Search
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The run element.
    /// </summary>
    public class Run
    {
        /// <summary>
        /// Gets or sets the duration in weeks.
        /// </summary>
        [JsonProperty("duration_in_weeks")]
        public string Duration_in_weeks { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime Start_date { get; set; }

        /// <summary>
        /// Gets or sets the uuid.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }
    }
}
