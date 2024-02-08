namespace LearningHub.Nhs.Models.Resource.Files
{
    /// <summary>
    /// Defines the <see cref="VideoFileStatus" />.
    /// </summary>
    public enum VideoFileStatus
    {
        /// <summary>
        /// Uploading.
        /// </summary>
        Uploading = 0,

        /// <summary>
        /// Queued for Processing.
        /// </summary>
        QueuedForProcessing = 1,

        /// <summary>
        /// Processing Complete.
        /// </summary>
        ProcessingComplete = 2,

        /// <summary>
        /// Processing Failed.
        /// </summary>
        ProcessingFailed = 3,
    }
}