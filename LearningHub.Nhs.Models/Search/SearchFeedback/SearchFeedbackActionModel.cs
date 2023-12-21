// <copyright file="SearchFeedbackActionModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback action model.
    /// </summary>
    public class SearchFeedbackActionModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFeedbackActionModel"/> class.
        /// </summary>
        public SearchFeedbackActionModel()
        {
            this.Payload = new SearchFeedbackPayloadModel();
        }

        /// <summary>
        /// Gets or sets the search feedback action payload.
        /// </summary>
        [JsonProperty(PropertyName = "payload")]
        public SearchFeedbackPayloadModel Payload { get; set; }
    }
}