namespace LearningHub.Nhs.Models.Entities.Messaging
{
    /// <summary>
    /// The Email Template.
    /// </summary>
    public class EmailTemplate : EntityBase
    {
        /// <summary>
        /// Gets or sets the email template type id.
        /// </summary>
        public int LayoutId { get; set; }

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

        /// <summary>
        /// Gets or sets the email template type.
        /// </summary>
        public EmailTemplateLayout EmailTemplateLayout { get; set; }
    }
}
