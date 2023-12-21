// <copyright file="RoleUserGroupViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The view model for modifying displaying user group - role - scope associations via Admin.
    /// </summary>
    public class RoleUserGroupViewModel
    {
        /// <summary>
        /// Gets or sets the key.
        /// </summary>
        [Key]
        public int Key { get; set; }

        /// <summary>
        /// Gets or sets the role user group id.
        /// </summary>
        public int RoleUserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group name.
        /// </summary>
        public string UserGroupName { get; set; }

        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets the role enum.
        /// </summary>
        public RoleEnum RoleEnum { get; set; }

        /// <summary>
        /// Gets or sets the scope id.
        /// </summary>
        public int? ScopeId { get; set; }

        /// <summary>
        /// Gets or sets the scope type.
        /// </summary>
        public ScopeTypeEnum? ScopeType { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int? CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int? CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }
    }
}
