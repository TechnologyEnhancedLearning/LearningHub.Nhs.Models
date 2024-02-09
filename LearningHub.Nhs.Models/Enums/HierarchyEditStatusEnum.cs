namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The hierarchy edit status enum.
    /// </summary>
    public enum HierarchyEditStatusEnum
    {
        /// <summary>
        /// The draft.
        /// </summary>
        Draft = 1,

        /// <summary>
        /// The published.
        /// </summary>
        Published = 2,

        /// <summary>
        /// The discarded.
        /// </summary>
        Discarded = 3,

        /// <summary>
        /// The publishing.
        /// </summary>
        Publishing = 4,

        /// <summary>
        /// Submitted to publishing queue.
        /// </summary>
        SubmittedToPublishingQueue = 5,

        /// <summary>
        /// Failed to publish.
        /// </summary>
        FailedToPublish = 6,
    }
}
