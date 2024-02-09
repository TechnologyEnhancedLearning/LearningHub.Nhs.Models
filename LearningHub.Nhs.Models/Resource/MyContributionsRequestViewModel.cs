namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The my contributions request view model.
    /// </summary>
    public class MyContributionsRequestViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue id.
        /// </summary>
        public int? CatalogueId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public VersionStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        public ResourceTypeEnum ResourceType { get; set; }
    }
}
