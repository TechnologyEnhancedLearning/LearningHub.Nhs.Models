// <copyright file="EmailChangeConfirmationEmailModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Email.Models
{
    using System;

    /// <summary>
    /// EmailChangeConfirmationEmailModel.
    /// </summary>
    public class EmailChangeConfirmationEmailModel
    {
        /// <summary>
        /// Gets or sets the first name of the user who requested access.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the validation token url.
        /// </summary>
        public string ValidationTokenUrl { get; set; }

        /// <summary>
        /// Gets or sets the time limit.
        /// </summary>
        public int TimeLimit { get; set; }

        /// <summary>
        /// Gets or sets support pages.
        /// </summary>
        public string SupportPages { get; set; }

        /// <summary>
        /// Gets or sets support form.
        /// </summary>
        public string SupportForm { get; set; }

        /// <summary>
        /// Gets or sets expirary date.
        /// </summary>
        public DateTime ExpiraryDate { get; set; }
    }
}
