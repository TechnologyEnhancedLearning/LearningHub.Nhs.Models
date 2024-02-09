﻿namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback stats model.
    /// </summary>
    public class SearchFeedbackStatsModel
    {
        /// <summary>
        /// Gets or sets the total hits.
        /// </summary>
        [JsonProperty(PropertyName = "totalHits")]
        public int TotalHits { get; set; }
    }
}