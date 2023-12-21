// <copyright file="PublishRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// Publish request model.
    /// </summary>
    public class PublishRequestViewModel
    {
        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the publish view model.
        /// </summary>
        public PublishViewModel PublishViewModel { get; set; }
    }
}
