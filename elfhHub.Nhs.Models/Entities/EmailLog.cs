// <copyright file="EmailLog.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The email log.
    /// </summary>
    public class EmailLog : EntityBase
    {
        /// <summary>
        /// Gets or sets the email template id.
        /// </summary>
        public int? EmailTemplateId { get; set; }

        /// <summary>
        /// Gets or sets the to user id.
        /// </summary>
        public int? ToUserId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the from email address.
        /// </summary>
        public string FromEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the to email address.
        /// </summary>
        public string ToEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the retries.
        /// </summary>
        public int Retries { get; set; }

        /// <summary>
        /// Gets or sets the sent date.
        /// </summary>
        public DateTimeOffset? SentDate { get; set; }

        /// <summary>
        /// Gets or sets the attachment file.
        /// </summary>
        public string AttachmentFile { get; set; }

        /// <summary>
        /// Gets or sets the programme component id.
        /// </summary>
        public int? ProgrammeComponentId { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the process date.
        /// </summary>
        public DateTimeOffset? ProcessDate { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets the email template.
        /// </summary>
        public virtual EmailTemplate EmailTemplate { get; set; }

        /// <summary>
        /// Gets or sets the to user.
        /// </summary>
        public virtual User ToUser { get; set; }
    }
}
