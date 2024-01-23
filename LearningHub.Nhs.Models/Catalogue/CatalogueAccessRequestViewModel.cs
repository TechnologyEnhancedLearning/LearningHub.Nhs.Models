// <copyright file="CatalogueAccessRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The CatalogueAccessRequestViewModel class.
    /// </summary>
    public class CatalogueAccessRequestViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user fullname.
        /// </summary>
        public string UserFullName { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public CatalogueAccessRequestStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the date requested.
        /// </summary>
        public DateTimeOffset DateRequested { get; set; }

        /// <summary>
        /// Gets or sets the date approved.
        /// </summary>
        public DateTimeOffset? DateApproved { get; set; }

        /// <summary>
        /// Gets or sets the date rejected.
        /// </summary>
        public DateTimeOffset? DateRejected { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the response message.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Gets or sets the last response message.
        /// </summary>
        public string LastResponseMessage { get; set; }
    }
}
