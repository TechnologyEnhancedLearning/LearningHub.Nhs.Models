// <copyright file="EmailChangeValidationToken.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user email change validation token.
    /// </summary>
    public class EmailChangeValidationToken : EntityBase
    {
        /// <summary>
        /// Gets or sets the hashed token.
        /// </summary>
        public string HashedToken { get; set; }

        /// <summary>
        /// Gets or sets the salt.
        /// </summary>
        public string Salt { get; set; }

        /// <summary>
        /// Gets or sets the lookup.
        /// </summary>
        public string Lookup { get; set; }

        /// <summary>
        /// Gets or sets the expiry.
        /// </summary>
        public DateTimeOffset Expiry { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the StatusId.
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }
    }
}
