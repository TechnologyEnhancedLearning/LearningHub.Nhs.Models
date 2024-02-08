namespace LearningHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The role.
    /// </summary>
    public partial class Role : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Role"/> class.
        /// </summary>
        public Role()
        {
            this.RoleUserGroup = new HashSet<RoleUserGroup>();
            this.PermissionRole = new HashSet<PermissionRole>();
        }

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

        /// <summary>
        /// Gets or sets the role user group.
        /// </summary>
        public virtual ICollection<RoleUserGroup> RoleUserGroup { get; set; }
    }
}
