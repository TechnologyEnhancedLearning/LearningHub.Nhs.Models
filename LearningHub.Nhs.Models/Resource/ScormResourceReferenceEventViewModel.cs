namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="ScormResourceReferenceEventViewModel" />.
    /// </summary>
    public class ScormResourceReferenceEventViewModel
    {
        /// <summary>
        /// Gets or sets the resource reference id..
        /// </summary>
        public int? ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource version event type..
        /// </summary>
        public ScormResourceReferenceEventTypeEnum ScormResourceReferenceEventType { get; set; }

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
