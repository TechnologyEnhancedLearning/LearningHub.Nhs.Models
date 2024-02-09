namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The email template.
    /// </summary>
    public class UserRoleUpgrade : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the upgrade date.
        /// </summary>
        public DateTimeOffset? UpgradeDate { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset? CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the user history type id.
        /// </summary>
        public int UserHistoryTypeId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }
    }
}
