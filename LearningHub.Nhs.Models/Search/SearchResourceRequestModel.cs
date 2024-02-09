namespace LearningHub.Nhs.Models.Search
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The search resource request model.
    /// </summary>
    public class SearchResourceRequestModel
    {
        /// <summary>
        /// Gets or sets the unique url.
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the resource reference id.
        /// </summary>
        [JsonProperty("resource_reference_id")]
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        [JsonProperty("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the authored date string.
        /// </summary>
        [JsonProperty("authored_date")]
        public string AuthoredDateString { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        [JsonProperty("authors")]
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the publication id.
        /// </summary>
        [JsonIgnore]
        public int PublicationId { get; set; }

        /// <summary>
        /// Gets or sets the publication date.
        /// </summary>
        [JsonProperty("publication_date")]
        public DateTimeOffset PublicationDate { get; set; }

        /// <summary>
        /// Gets or sets the rating.
        /// </summary>
        [JsonProperty("rating")]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Gets or sets the catalogue ids.
        /// </summary>
        [JsonProperty("catalogue_ids")]
        public List<int> CatalogueIds { get; set; }

        /// <summary>
        /// Gets or sets the location paths.
        /// </summary>
        [JsonProperty("location_paths")]
        public List<string> LocationPaths { get; set; }

        /// <summary>
        /// Gets or sets the resource access level.
        /// </summary>
        [JsonProperty("resource_access_level")]
        public int ResourceAccessLevel { get; set; }

        /// <summary>
        /// Gets or sets the provider ids.
        /// </summary>
        [JsonProperty("provider_ids")]
        public List<int> ProviderIds { get; set; }

        /// <summary>
        /// Indicates whether the search resource request is valid for submission.
        /// For initial Catalogues implementation a Resource must have a single Resource Reference
        /// and be published in a single Catalogue.
        /// </summary>
        /// <returns>Indication of whether the search resource request is valid for submission.</returns>
        public bool IsValidForSubmission()
        {
            return (this.ResourceReferenceId != 0)
                         && (this.CatalogueIds.Count == 1);
        }
    }
}
