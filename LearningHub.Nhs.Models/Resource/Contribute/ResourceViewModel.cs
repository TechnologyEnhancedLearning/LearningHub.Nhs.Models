namespace LearningHub.Nhs.Models.Resource.Contribute
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource view model.
    /// </summary>
    public class ResourceViewModel
    {
        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource type.
        /// </summary>
        public ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the current resource version id.
        /// </summary>
        public int? CurrentResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the original resource version id for a duplicated resource.
        /// </summary>
        public int? DuplicatedFromResourceVersionId { get; set; }
    }
}
