// <copyright file="UserPasswordValidationToken.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user password validation token.
    /// </summary>
    public class UserPasswordValidationToken
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

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
        /// Gets or sets the created user id.
        /// </summary>
        public int CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }
    }
}
