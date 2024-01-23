// <copyright file="EmailRecipientViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Messaging
{
    using System.Collections.Generic;

    /// <summary>
    /// The EmailRecipientViewModel class.
    /// </summary>
    public class EmailRecipientViewModel
    {
        /// <summary>
        /// Gets or sets the email addresses.
        /// </summary>
        public List<string> EmailAddresses { get; set; }
    }
}
