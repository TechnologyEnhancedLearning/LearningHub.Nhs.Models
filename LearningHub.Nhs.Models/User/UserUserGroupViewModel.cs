// <copyright file="UserUserGroupViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.User
{
    /// <summary>
    /// The view model for modifying user user group associations via Admin.
    /// </summary>
    public class UserUserGroupViewModel
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group name.
        /// </summary>
        public string UserGroupName { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string UserName { get; set; }
    }
}
