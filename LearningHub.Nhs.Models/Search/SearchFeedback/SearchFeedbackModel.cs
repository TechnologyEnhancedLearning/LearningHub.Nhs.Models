// <copyright file="SearchFeedbackModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Search.SearchFeedback
{
    using Newtonsoft.Json;

    /// <summary>
    /// The search feedback model.
    /// </summary>
    public class SearchFeedbackModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFeedbackModel"/> class.
        /// </summary>
        public SearchFeedbackModel()
        {
            this.FeedbackAction = new SearchFeedbackActionModel();
        }

        /// <summary>
        /// Gets or sets the feedback action.
        /// </summary>
        [JsonProperty(PropertyName = "feedbackAction")]
        public SearchFeedbackActionModel FeedbackAction { get; set; }
    }
}