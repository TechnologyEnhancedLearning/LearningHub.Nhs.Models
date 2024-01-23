// <copyright file="CreateResourceActivityViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource activity view model.
    /// </summary>
    public class CreateResourceActivityViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the launch resource activity id.
        /// </summary>
        public int? LaunchResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the activity status.
        /// </summary>
        public ActivityStatusEnum ActivityStatus { get; set; }

        /// <summary>
        /// Gets or sets the activity start.
        /// </summary>
        public DateTimeOffset? ActivityStart { get; set; }

        /// <summary>
        /// Gets or sets the activity end.
        /// </summary>
        public DateTimeOffset? ActivityEnd { get; set; }

        /// <summary>
        /// Gets or sets the media resource activity id. Only populated when ending a media activity.
        /// </summary>
        public int? MediaResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the extra attempt reason.
        /// </summary>
        public string ExtraAttemptReason { get; set; }
    }
}
