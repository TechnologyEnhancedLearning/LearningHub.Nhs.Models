// <copyright file="RestrictedCatalogueUsersViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System.Collections.Generic;

    /// <summary>
    /// The RestrictedCatalogueUsersViewModel class.
    /// </summary>
    public class RestrictedCatalogueUsersViewModel
    {
        /// <summary>
        /// Gets or sets the user count.
        /// </summary>
        public int UserCount { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public List<RestrictedCatalogueUserViewModel> RestrictedCatalogueUsers { get; set; }
    }
}
