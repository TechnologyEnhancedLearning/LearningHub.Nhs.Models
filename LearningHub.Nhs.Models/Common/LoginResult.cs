// <copyright file="LoginResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The login result.
    /// </summary>
    public class LoginResult
    {
        /// <summary>
        /// Gets or sets a value indicating whether is authenticated.
        /// </summary>
        public bool IsAuthenticated { get; set; }

        /// <summary>
        /// Gets or sets the error message.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
