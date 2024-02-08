namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user  provider.
    /// </summary>
    public partial class UserProvider : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the provider id.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the removal date.
        /// </summary>
        public DateTimeOffset? RemovalDate { get; set; }
    }
}
