// <copyright file="UserHistory.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The user history.
    /// </summary>
    public class UserHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHistory"/> class.
        /// </summary>
        public UserHistory()
        {
            this.UserHistoryAttribute = new HashSet<UserHistoryAttribute>();
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user history type id.
        /// </summary>
        public int UserHistoryTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user history attribute.
        /// </summary>
        public virtual ICollection<UserHistoryAttribute> UserHistoryAttribute { get; set; }
    }
}
