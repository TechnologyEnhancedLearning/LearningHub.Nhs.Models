namespace elfhHub.Nhs.Models.Common
{
    using System;

    /// <summary>
    /// The user basic.
    /// </summary>
    public class UserBasic
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user name..
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name..
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name..
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address..
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the LastUpdated.
        /// </summary>
        public DateTimeOffset LastUpdated { get; set; }
    }
}
