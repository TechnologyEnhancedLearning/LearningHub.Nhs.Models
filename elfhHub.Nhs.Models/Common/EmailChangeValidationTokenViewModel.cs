// <copyright file="EmailChangeValidationTokenViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// EmailChangeValidationTokenViewModel.
    /// </summary>
    public class EmailChangeValidationTokenViewModel
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the lookup.
        /// </summary>
        public string Lookup { get; set; }

        /// <summary>
        /// Gets or sets the StatusId.
        /// </summary>
        public int StatusId { get; set; }
    }
}
