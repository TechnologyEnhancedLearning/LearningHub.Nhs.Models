// <copyright file="SearchResultModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search results model.
    /// </summary>
    public class SearchResultModel : SearchResultModelBase
    {
        /// <summary>
        /// Gets or sets the document list.
        /// </summary>
        [JsonProperty("documentList")]
        public Documentlist DocumentList { get; set; }
    }
}
