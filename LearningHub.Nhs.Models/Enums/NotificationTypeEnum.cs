namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The notification type enum.
    /// </summary>
    public enum NotificationTypeEnum
    {
        /// <summary>
        /// The system update.
        /// </summary>
        SystemUpdate = 1,

        /// <summary>
        /// The system release.
        /// </summary>
        SystemRelease = 2,

        /// <summary>
        /// The action required.
        /// </summary>
        ActionRequired = 3,

        /// <summary>
        /// The resource published.
        /// </summary>
        ResourcePublished = 4,

        /// <summary>
        /// The resource rated.
        /// </summary>
        ResourceRated = 5,

        /// <summary>
        /// The user permission.
        /// </summary>
        UserPermission = 6,

        /// <summary>
        /// The publish failed.
        /// </summary>
        PublishFailed = 7,

        /// <summary>
        /// The access request.
        /// </summary>
        AccessRequest = 8,
    }
}