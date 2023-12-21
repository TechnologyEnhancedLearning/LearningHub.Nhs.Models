// <copyright file="RolePermissionsViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    using System.Collections.Generic;

    /// <summary>
    /// The Role Permissions View Model.
    /// </summary>
    public class RolePermissionsViewModel
    {
        /// <summary>
        /// Gets or sets Role Id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets Permissions.
        /// </summary>
        public IEnumerable<string> Permissions { get; set; }
    }
}