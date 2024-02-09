namespace LearningHub.Nhs.Models.Dto
{
    /// <summary>
    /// The Scorm Activity Summary Dto.
    /// </summary>
    public class ScormActivitySummaryDto
    {
        /// <summary>
        /// Gets or sets the IncompleteActivityId.
        /// </summary>
        public int? IncompleteActivityId { get; set; }

        /// <summary>
        /// Gets or sets the Total Session Time.
        /// </summary>
        public string TotalTime { get; set; }
    }
}
