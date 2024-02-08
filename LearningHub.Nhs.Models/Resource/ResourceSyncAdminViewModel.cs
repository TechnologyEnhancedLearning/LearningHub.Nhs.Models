namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The ResourceSyncAdminViewModel.
    /// </summary>
    public class ResourceSyncAdminViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource type enum.
        /// </summary>
        public ResourceTypeEnum ResourceTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the version status enum.
        /// </summary>
        public VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }
    }
}
