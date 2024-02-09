namespace elfhHub.Nhs.Models.Common
{
    using System;

    /// <summary>
    /// The user role upgrade view model.
    /// </summary>
    public class UserRoleUpgradeViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the upgrade date.
        /// </summary>
        public DateTimeOffset? UpgradeDate { get; set; }
    }
}
