namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The active content release view model.
    /// </summary>
    public class ActiveContentReleaseViewModel
    {
        /// <summary>
        /// Gets or sets the userid.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the release all.
        /// </summary>
        public bool ReleaseAll { get; set; }

        /// <summary>
        /// Gets or sets the scorm activity id.
        /// </summary>
        public int ScormActivityId { get; set; }
    }
}
