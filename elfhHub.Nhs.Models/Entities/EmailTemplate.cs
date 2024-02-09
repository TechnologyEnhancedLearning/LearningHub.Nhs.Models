namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The email template.
    /// </summary>
    public class EmailTemplate : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailTemplate"/> class.
        /// </summary>
        public EmailTemplate()
        {
            this.EmailLog = new HashSet<EmailLog>();
        }

        /// <summary>
        /// Gets or sets the email template type id.
        /// </summary>
        public int EmailTemplateTypeId { get; set; }

        /// <summary>
        /// Gets or sets the programme component id.
        /// </summary>
        public int ProgrammeComponentId { get; set; }

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
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the email log.
        /// </summary>
        public virtual ICollection<EmailLog> EmailLog { get; set; }

        /// <summary>
        /// Gets or sets the email template type.
        /// </summary>
        public virtual EmailTemplateType EmailTemplateType { get; set; }
    }
}
