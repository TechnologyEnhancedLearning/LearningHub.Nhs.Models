// <copyright file="UserAuthenticateDto.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Dto
{
    using System;

    /// <summary>
    /// The user authenticate dto.
    /// </summary>
    public class UserAuthenticateDto
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password life counter.
        /// </summary>
        public int PasswordLifeCounter { get; set; }

        /// <summary>
        /// Gets or sets the password hash.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the active from date.
        /// </summary>
        public DateTimeOffset? ActiveFromDate { get; set; }

        /// <summary>
        /// Gets or sets the active to date.
        /// </summary>
        public DateTimeOffset? ActiveToDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the restrict to sso.
        /// </summary>
        public bool RestrictToSso { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether gets or sets the open athens user attribute id.
        /// </summary>
        public int? OpenAthensUserAttributeId { get; set; }
    }
}
