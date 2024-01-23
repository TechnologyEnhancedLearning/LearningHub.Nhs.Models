// <copyright file="UserGroupAdminBasicViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    using System;

    /// <summary>
    /// The view model for user group search screen in Admin.
    /// </summary>
    public class UserGroupAdminBasicViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the group name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the amend date.
        /// </summary>
        public DateTimeOffset AmendDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user group is used on any catalogue.
        /// </summary>
        public bool HasCatalogues { get; set; }

        /// <summary>
        /// Indicates whether the User Group is new.
        /// </summary>
        /// <returns>bool.</returns>
        public bool IsNew()
        {
            return this.Id == 0;
        }

        /// <summary>
        /// Indicates whether the User Group can be edited.
        /// </summary>
        /// <returns>bool.</returns>
        public bool CanEdit()
        {
            return this.IsNew() || this.Id >= 10000;
        }
    }
}
