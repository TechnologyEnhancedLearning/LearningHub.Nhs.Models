// <copyright file="UserAdminDetailViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The view model for user detail screen in Admin.
    /// </summary>
    public class UserAdminDetailViewModel : UserAdminBasicViewModel
    {
        /// <summary>
        /// Gets or sets the OriginalFirstName.
        /// </summary>
        public string OriginalFirstName { get; set; }

        /// <summary>
        /// Gets or sets the OriginalLastName.
        /// </summary>
        public string OriginalLastName { get; set; }

        /// <summary>
        /// Gets or sets the OriginalEmailAddress.
        /// </summary>
        public string OriginalEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the ActiveFromDate.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTimeOffset? ActiveFromDate { get; set; }

        /// <summary>
        /// Gets or sets the ActiveToDate.
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTimeOffset? ActiveToDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the LoginTimes.
        /// </summary>
        public int LoginTimes { get; set; }

        /// <summary>
        /// Gets or sets the FailedLoginCount.
        /// </summary>
        public int FailedLoginCount { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user is a Learning Hub read-only user.
        /// </summary>
        public bool ReadOnlyUser { get; set; }

        /// <summary>
        /// Gets or sets the user role upgrade.
        /// </summary>
        public List<UserRoleUpgradeViewModel> UserRoleUpgrade { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string RoleName { get; set; }
    }
}
