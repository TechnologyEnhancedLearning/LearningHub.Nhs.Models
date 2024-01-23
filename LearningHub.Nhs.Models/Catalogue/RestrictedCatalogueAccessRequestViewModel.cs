// <copyright file="RestrictedCatalogueAccessRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The RestrictedCatalogueAccessRequestViewModel class.
    /// </summary>
    public class RestrictedCatalogueAccessRequestViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue access request id.
        /// </summary>
        [Key]
        public int CatalogueAccessRequestId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the catalogue access request status.
        /// </summary>
        public CatalogueAccessRequestStatus CatalogueAccessRequestStatus { get; set; }

        /// <summary>
        /// Gets or sets the requested datetime.
        /// </summary>
        public DateTimeOffset? RequestedDatetime { get; set; }
    }
}
