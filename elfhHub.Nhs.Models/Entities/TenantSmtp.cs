// <copyright file="TenantSmtp.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The tenant smtp.
    /// </summary>
    public class TenantSmtp : EntityBase
    {
        /// <summary>
        /// Gets or sets the delivery method.
        /// </summary>
        public string DeliveryMethod { get; set; }

        /// <summary>
        /// Gets or sets the pickup directory location.
        /// </summary>
        public string PickupDirectoryLocation { get; set; }

        /// <summary>
        /// Gets or sets the from.
        /// </summary>
        public string From { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether enable ssl.
        /// </summary>
        public bool EnableSsl { get; set; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }
    }
}
