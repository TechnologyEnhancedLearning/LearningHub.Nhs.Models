// <copyright file="LinkUserToSsoRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// The link existing user to sso request view model.
    /// </summary>
    public class LinkUserToSsoRequestViewModel
    {
        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the external system id.
        /// </summary>
        public int ExternalSystemId { get; set; }

        /// <summary>
        /// Gets or sets the external system code.
        /// </summary>
        public string ExternalSystemCode { get; set; }
    }
}
