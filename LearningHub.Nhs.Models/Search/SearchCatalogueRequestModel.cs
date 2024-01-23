// <copyright file="SearchCatalogueRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The SearchCatalogueRequestModel.
    /// </summary>
    public class SearchCatalogueRequestModel
    {
        /// <summary>
        /// Gets or sets the catalogue id.
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is hidden.
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        [JsonProperty("provider_ids")]
        public List<int> ProviderIds { get; set; }
    }
}
