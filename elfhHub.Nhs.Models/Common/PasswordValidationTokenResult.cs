// <copyright file="PasswordValidationTokenResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// The password validation token result.
    /// </summary>
    public class PasswordValidationTokenResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether valid.
        /// </summary>
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or sets the token issue.
        /// </summary>
        public string TokenIssue { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }
    }
}
