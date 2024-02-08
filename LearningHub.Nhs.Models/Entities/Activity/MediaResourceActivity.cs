namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The MediaResourceActivity.
    /// </summary>
    public partial class MediaResourceActivity : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaResourceActivity"/> class.
        /// </summary>
        public MediaResourceActivity()
        {
            this.MediaResourceActivityInteraction = new HashSet<MediaResourceActivityInteraction>();
        }

        /// <summary>
        /// Gets or sets the ResourceActivityId.
        /// </summary>
        public int ResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the ActivityStart.
        /// </summary>
        public DateTimeOffset ActivityStart { get; set; }

        /// <summary>
        /// Gets or sets the number of seconds of the media that were played during this particular activity.
        /// i.e. if the user watched the first 30 seconds of a video twice, this value would be 30, not 60.
        /// </summary>
        public int? SecondsPlayed { get; set; }

        /// <summary>
        /// Gets or sets the OVERALL completion percentage, of this activity plus all earlier activities relating to the same resource.
        /// i.e. this is cumulative.
        /// </summary>
        public decimal? PercentComplete { get; set; }

        /// <summary>
        /// Gets or sets the ResourceActivity.
        /// </summary>
        public virtual ResourceActivity ResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the MediaResourceActivityInteraction.
        /// </summary>
        public virtual ICollection<MediaResourceActivityInteraction> MediaResourceActivityInteraction { get; set; }
    }
}
