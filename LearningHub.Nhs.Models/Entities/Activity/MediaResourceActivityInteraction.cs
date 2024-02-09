namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System;

    /// <summary>
    /// The MediaResourceActivityInteraction.
    /// </summary>
    public partial class MediaResourceActivityInteraction : EntityBase
    {
        /// <summary>
        /// Gets or sets the Media Resource ActivityId.
        /// </summary>
        public int MediaResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the Media Display Time.
        /// </summary>
        public TimeSpan DisplayTime { get; set; }

        /// <summary>
        /// Gets or sets the Media Resource Activity Type.
        /// </summary>
        public int MediaResourceActivityTypeId { get; set; }

        /// <summary>
        /// Gets or sets the client's date and time when the activity occurred.
        /// </summary>
        public DateTimeOffset ClientDateTime { get; set; }

        /// <summary>
        /// Gets or sets the Media Resource Activity Type.
        /// </summary>
        public virtual MediaResourceActivityType MediaResourceActivityType { get; set; }
    }
}
