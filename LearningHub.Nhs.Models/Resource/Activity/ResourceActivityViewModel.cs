namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource activity view model.
    /// </summary>
    public class ResourceActivityViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the launch resource activity id.
        /// </summary>
        public int? LaunchResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the MajorVersion.
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the MinorVersion.
        /// </summary>
        public int MinorVersion { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int? NodePathId { get; set; }

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
        /// Gets or sets the duration seconds.
        /// </summary>
        public int DurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets the score.
        /// </summary>
        public double? Score { get; set; }
    }
}
