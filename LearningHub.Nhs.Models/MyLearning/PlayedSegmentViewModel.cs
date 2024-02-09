namespace LearningHub.Nhs.Models.MyLearning
{
    /// <summary>
    /// The played segment view model. Used in My Learning screen progress popup.
    /// </summary>
    public class PlayedSegmentViewModel
    {
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
    }
}
