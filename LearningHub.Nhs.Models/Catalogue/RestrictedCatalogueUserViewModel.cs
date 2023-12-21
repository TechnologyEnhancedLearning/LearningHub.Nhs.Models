// <copyright file="RestrictedCatalogueUserViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The RestrictedCatalogueUserViewModel class.
    /// </summary>
    public class RestrictedCatalogueUserViewModel
    {
        /// <summary>
        /// Gets or sets the user-user group id.
        /// </summary>
        [Key]
        public int UserUserGroupId { get; set; }

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
        /// Gets or sets the added by username.
        /// </summary>
        public string AddedByUsername { get; set; }

        /// <summary>
        /// Gets or sets the added by datetime.
        /// </summary>
        public DateTimeOffset? AddedDatetime { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user can be removed from the default restricted access group.
        /// </summary>
        public bool CanRemove { get; set; }
    }
}
