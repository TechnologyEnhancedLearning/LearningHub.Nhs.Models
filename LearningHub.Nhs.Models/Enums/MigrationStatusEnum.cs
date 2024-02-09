namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The migration status enum.
    /// </summary>
    public enum MigrationStatusEnum
    {
        /// <summary>
        /// The created.
        /// </summary>
        Created,

        /// <summary>
        /// The validating.
        /// </summary>
        Validating,

        /// <summary>
        /// The validated.
        /// </summary>
        Validated,

        /// <summary>
        /// The creating lh metadata.
        /// </summary>
        CreatingLHMetadata,

        /// <summary>
        /// The created lh metadata.
        /// </summary>
        CreatedLHMetadata,

        /// <summary>
        /// The publishing lh resources.
        /// </summary>
        PublishingLHResources,

        /// <summary>
        /// The published lh resources.
        /// </summary>
        PublishedLHResources,

        /// <summary>
        /// The abandoned.
        /// </summary>
        Abandoned,
    }
}
