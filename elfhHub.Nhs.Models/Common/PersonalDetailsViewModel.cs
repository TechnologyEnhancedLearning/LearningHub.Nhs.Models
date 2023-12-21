// <copyright file="PersonalDetailsViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    using System;

    /// <summary>
    /// The personal details view model.
    /// </summary>
    public class PersonalDetailsViewModel
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred name.
        /// </summary>
        public string PreferredName { get; set; }

        /// <summary>
        /// Gets or sets the primary email address.
        /// </summary>
        public string PrimaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the secondary email address.
        /// </summary>
        public string SecondaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the LastUpdated.
        /// </summary>
        public DateTimeOffset LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets the PasswordHash.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the new primary email address.
        /// </summary>
        public string NewPrimaryEmailAddress { get; set; }
    }
}
