namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource version event.
    /// </summary>
    public partial class ResourceVersionEvent : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource version event type.
        /// </summary>
        public ResourceVersionEventTypeEnum ResourceVersionEventType { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }
    }
}
