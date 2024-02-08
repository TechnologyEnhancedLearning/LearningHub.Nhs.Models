namespace LearningHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The user group.
    /// </summary>
    public partial class UserGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the role user group.
        /// </summary>
        public virtual ICollection<RoleUserGroup> RoleUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the user group attribute details.
        /// </summary>
        public virtual ICollection<UserGroupAttribute> UserGroupAttribute { get; set; }

        /// <summary>
        /// Gets or sets the user user group.
        /// </summary>
        public virtual ICollection<UserUserGroup> UserUserGroup { get; set; }
    }
}
