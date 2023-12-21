// <copyright file="Facet.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The facet element.
    /// </summary>
    public class Facet
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
        /// Gets or sets the selection type.
        /// </summary>
        [JsonProperty("selectionType")]
        public string SelectionType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multiple levels.
        /// </summary>
        [JsonProperty("multipleLevels")]
        public bool MultipleLevels { get; set; }

        /// <summary>
        /// Gets or sets the filters.
        /// </summary>
        [JsonProperty("filters")]
        public Filter[] Filters { get; set; }
    }
}
