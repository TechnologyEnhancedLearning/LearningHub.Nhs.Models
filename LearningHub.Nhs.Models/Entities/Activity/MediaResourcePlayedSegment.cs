namespace LearningHub.Nhs.Models.Entities.Activity
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The MediaResourcePlayedSegment.
    /// </summary>
    public partial class MediaResourcePlayedSegment : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaResourcePlayedSegment"/> class.
        /// </summary>
        public MediaResourcePlayedSegment()
        {
        }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the MajorVersion.
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the SegmentStartTime.
        /// </summary>
        public int SegmentStartTime { get; set; }

        /// <summary>
        /// Gets or sets the SegmentEndTime.
        /// </summary>
        public int SegmentEndTime { get; set; }

        /// <summary>
        /// Gets or sets the SegmentDuration.
        /// </summary>
        public int SegmentDuration { get; set; }

        /// <summary>
        /// Gets or sets the ResourceActivity.
        /// </summary>
        public virtual Resource Resource { get; set; }
    }
}
