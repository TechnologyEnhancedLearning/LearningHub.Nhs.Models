// <copyright file="SearchCatalogueResultModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The SearchCatalogueResultModel.
    /// </summary>
    public class SearchCatalogueResultModel : SearchResultModelBase
    {
        /// <summary>
        /// Gets or sets the documents.
        /// </summary>
        [JsonProperty("documentList")]
        public CatalogueDocumentList DocumentList { get; set; }
    }
}
