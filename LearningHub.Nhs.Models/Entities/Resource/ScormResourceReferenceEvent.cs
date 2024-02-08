namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource version event.
    /// </summary>
    public partial class ScormResourceReferenceEvent : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource reference id.
        /// </summary>
        public int? ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource version event type.
        /// </summary>
        public int ScormResourceReferenceEventTypeId { get; set; }

        /// <summary>
        /// Gets or sets the HttpRefererer.
        /// </summary>
        public string HttpRefererer { get; set; }

        /// <summary>
        /// Gets or sets the IPAddress.
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }
    }
}
