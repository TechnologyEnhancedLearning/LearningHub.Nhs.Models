namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The user group.
    /// </summary>
    public partial class UserGroup : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserGroup"/> class.
        /// </summary>
        public UserGroup()
        {
            ////RoleUserGroup = new HashSet<RoleUserGroup>();
            this.UserUserGroup = new HashSet<UserUserGroup>();
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

        ////public virtual UserGroupType UserGroupType { get; set; }
        ////public virtual ICollection<RoleUserGroup> RoleUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the user user group.
        /// </summary>
        public virtual ICollection<UserUserGroup> UserUserGroup { get; set; }
    }
}
