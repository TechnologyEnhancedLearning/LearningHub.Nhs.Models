namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The Email Template.
    /// </summary>
    public class NotificationTemplate : EntityBase
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the available tags.
        /// </summary>
        public string AvailableTags { get; set; }
    }
}
