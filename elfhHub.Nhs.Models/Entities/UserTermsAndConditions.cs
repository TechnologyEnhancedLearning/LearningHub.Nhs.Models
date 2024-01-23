// <copyright file="UserTermsAndConditions.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user terms and conditions.
    /// </summary>
    public class UserTermsAndConditions : EntityBase
    {
        /// <summary>
        /// Gets or sets the terms and conditions id.
        /// </summary>
        public int TermsAndConditionsId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the acceptance date.
        /// </summary>
        public DateTimeOffset AcceptanceDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the terms and conditions.
        /// </summary>
        public virtual TermsAndConditions TermsAndConditions { get; set; }
    }
}
