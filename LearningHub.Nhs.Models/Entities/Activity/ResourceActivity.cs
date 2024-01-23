// <copyright file="ResourceActivity.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The file type.
    /// </summary>
    public partial class ResourceActivity : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceActivity"/> class.
        /// </summary>
        public ResourceActivity()
        {
            this.InverseLaunchResourceActivity = new HashSet<ResourceActivity>();
            this.MediaResourceActivity = new HashSet<MediaResourceActivity>();
            this.AssessmentResourceActivity = new HashSet<AssessmentResourceActivity>();
            this.ScormActivity = new HashSet<ScormActivity>();
        }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersionId.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the launch resource activity id.
        /// </summary>
        public int? LaunchResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the MajorVersion.
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the MinorVersion.
        /// </summary>
        public int MinorVersion { get; set; }

        /// <summary>
        /// Gets or sets the NodePathId.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the ActivityStatusId.
        /// </summary>
        public int ActivityStatusId { get; set; }

        /// <summary>
        /// Gets or sets the ActivityStart.
        /// </summary>
        public DateTimeOffset? ActivityStart { get; set; }

        /// <summary>
        /// Gets or sets the ActivityEnd.
        /// </summary>
        public DateTimeOffset? ActivityEnd { get; set; }

        /// <summary>
        /// Gets or sets the DurationSeconds.
        /// </summary>
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets the Score.
        /// </summary>
        public decimal? Score { get; set; }

        /// <summary>
        /// Gets or sets the Resource.
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersion.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the ActivityStatus.
        /// </summary>
        public virtual ActivityStatus ActivityStatus { get; set; }

        /// <summary>
        /// Gets or sets the LaunchResourceActivity.
        /// </summary>
        public virtual ResourceActivity LaunchResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the NodePath.
        /// </summary>
        public virtual NodePath NodePath { get; set; }

        /// <summary>
        /// Gets or sets the InverseLaunchResourceActivity.
        /// </summary>
        public virtual ICollection<ResourceActivity> InverseLaunchResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the MediaResourceActivity.
        /// </summary>
        public virtual ICollection<MediaResourceActivity> MediaResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the AssessmentResourceActivity.
        /// </summary>
        public virtual ICollection<AssessmentResourceActivity> AssessmentResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the scorm activity.
        /// </summary>
        public virtual ICollection<ScormActivity> ScormActivity { get; set; }
    }
}