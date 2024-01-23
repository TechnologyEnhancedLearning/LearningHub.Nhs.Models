// <copyright file="UserGroupAdminDetailViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    /// <summary>
    /// The view model for user group detail screen in Admin.
    /// </summary>
    public class UserGroupAdminDetailViewModel : UserGroupAdminBasicViewModel
    {
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the OriginalName.
        /// </summary>
        public string OriginalName { get; set; }

        /// <summary>
        /// Gets or sets the OriginalDescription.
        /// </summary>
        public string OriginalDescription { get; set; }
    }
}
