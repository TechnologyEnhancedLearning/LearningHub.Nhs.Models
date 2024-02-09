namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The create media resource activity interaction view model.
    /// </summary>
    public class CreateMediaResourceActivityInteractionViewModel
    {
        /// <summary>
        /// Gets or sets the media resource activity id.
        /// </summary>
        public int MediaResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the media resource activity type.
        /// </summary>
        public MediaResourceActivityTypeEnum MediaResourceActivityType { get; set; }

        /// <summary>
        /// Gets or sets the current display time of media in seconds.
        /// </summary>
        public double DurationInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the client's date and time when the activity occurred.
        /// </summary>
        public DateTimeOffset ClientDateTime { get; set; }
    }
}
