// <copyright file="CatalogueDocument.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Provider;
    using Newtonsoft.Json;

    /// <summary>
    /// The cataloge document.
    /// </summary>
    public class CatalogueDocument
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the batch id.
        /// </summary>
        [JsonProperty("_batchid")]
        public string BatchId { get; set; }

        /// <summary>
        /// Gets or sets the collection.
        /// </summary>
        [JsonProperty("_collection")]
        public string Collection { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

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
        [JsonConverter(typeof(SingleOrArrayConverter<string>))]
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        [JsonConverter(typeof(SingleOrArrayConverter<int>))]
        [JsonProperty("provider_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> ProviderIds { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the badge url.
        /// </summary>
        public string BadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets the banner url.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue card image url.
        /// </summary>
        public string CardImageUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted.
        /// </summary>
        public bool RestrictedAccess { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has access to the resticted catalogue.
        /// </summary>
        public bool HasAccess { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the node bookmark id.
        /// </summary>
        public int? BookmarkId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether catalogue is bookmarked.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public List<ProviderViewModel> Providers { get; set; }
    }
}
