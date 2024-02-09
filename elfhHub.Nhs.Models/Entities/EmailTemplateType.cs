namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The email template type.
    /// </summary>
    public class EmailTemplateType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplateType"/> class.
        /// </summary>
        public EmailTemplateType()
        {
            this.EmailTemplate = new HashSet<EmailTemplate>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the available tags.
        /// </summary>
        public string AvailableTags { get; set; }

        /// <summary>
        /// Gets or sets the email template.
        /// </summary>
        public virtual ICollection<EmailTemplate> EmailTemplate { get; set; }
    }
}
