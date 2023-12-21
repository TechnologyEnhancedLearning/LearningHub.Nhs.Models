// <copyright file="TermsAndConditions.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The terms and conditions.
    /// </summary>
    public class TermsAndConditions : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TermsAndConditions"/> class.
        /// </summary>
        public TermsAndConditions()
        {
            this.UserTermsAndConditions = new HashSet<UserTermsAndConditions>();
        }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether reportable.
        /// </summary>
        public bool Reportable { get; set; }

        /// <summary>
        /// Gets or sets the user terms and conditions.
        /// </summary>
        public virtual ICollection<UserTermsAndConditions> UserTermsAndConditions { get; set; }
    }
}
