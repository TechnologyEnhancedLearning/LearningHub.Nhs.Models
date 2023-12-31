﻿// <copyright file="CatalogueDocumentList.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The catalogue document list.
    /// </summary>
    public class CatalogueDocumentList
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
        /// Gets or sets the number of hits.
        /// </summary>
        [JsonProperty("numberOfHits")]
        public int NumberOfHits { get; set; }

        /// <summary>
        /// Gets or sets the pagination.
        /// </summary>
        [JsonProperty("pagination")]
        public object Pagination { get; set; }

        /// <summary>
        /// Gets or sets the sort options.
        /// </summary>
        [JsonProperty("sortOptions")]
        public object[] SortOptions { get; set; }

        /// <summary>
        /// Gets or sets the documents.
        /// </summary>
        [JsonProperty("documents")]
        public CatalogueDocument[] Documents { get; set; }
    }
}
