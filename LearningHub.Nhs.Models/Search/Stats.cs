// <copyright file="Stats.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The Stats element.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// Gets or sets the total hits.
        /// </summary>
        [JsonProperty("totalHits")]
        public int TotalHits { get; set; }

        /// <summary>
        /// Gets or sets the search engine time in millis.
        /// </summary>
        [JsonProperty("searchEngineTimeInMillis")]
        public int SearchEngineTimeInMillis { get; set; }

        /// <summary>
        /// Gets or sets the search engine round trip time in millis.
        /// </summary>
        [JsonProperty("searchEngineRoundTripTimeInMillis")]
        public int SearchEngineRoundTripTimeInMillis { get; set; }

        /// <summary>
        /// Gets or sets the total hits.
        /// </summary>
        [JsonProperty("searchProcessingTimeInMillis")]
        public int SearchProcessingTimeInMillis { get; set; }
    }
}
