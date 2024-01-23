// <copyright file="ResourceVersionEventViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.ViewModels.Helpers;

    /// <summary>
    /// The resource version event view model.
    /// </summary>
    public class ResourceVersionEventViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the resource version event type.
        /// </summary>
        public ResourceVersionEventTypeEnum ResourceVersionEventType { get; set; }

        /// <summary>
        /// Gets the resource version event type description.
        /// </summary>
        public string ResourceVersionEventTypeDescription => ResourceHelper.GetResourceVersionEventTypeDescription(this.ResourceVersionEventType);

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }
    }
}
