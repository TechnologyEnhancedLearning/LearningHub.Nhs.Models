// <copyright file="RoleUserGroupUpdateViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The view model for updating a RoleUserGroup (create / delete).
    /// </summary>
    public class RoleUserGroupUpdateViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the scope type.
        /// </summary>
        public ScopeTypeEnum ScopeType { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int? CatalogueNodeId { get; set; }
    }
}
