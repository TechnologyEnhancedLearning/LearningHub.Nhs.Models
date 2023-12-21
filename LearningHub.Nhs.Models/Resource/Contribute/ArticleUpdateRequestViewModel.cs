// <copyright file="ArticleUpdateRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    using LearningHub.Nhs.Models.Binders;

    /// <summary>
    /// The article update request view model.
    /// </summary>
    public class ArticleUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the content.
        /// </summary>
        [SanitizedHtmlModelBinder]
        public string Description { get; set; }
    }
}
