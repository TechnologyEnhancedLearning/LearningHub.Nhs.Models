// <copyright file="Permission.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The permission.
    /// </summary>
    public partial class Permission : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission"/> class.
        /// </summary>
        public Permission()
        {
            this.PermissionRole = new HashSet<PermissionRole>();
        }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the permission role.
        /// </summary>
        public virtual ICollection<PermissionRole> PermissionRole { get; set; }
    }
}
