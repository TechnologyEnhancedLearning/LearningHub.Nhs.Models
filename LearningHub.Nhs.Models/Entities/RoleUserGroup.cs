namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The role user group.
    /// </summary>
    public partial class RoleUserGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the role id.
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the scope id.
        /// </summary>
        public int? ScopeId { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        public virtual Role Role { get; set; }

        /// <summary>
        /// Gets or sets the user group.
        /// </summary>
        public virtual UserGroup UserGroup { get; set; }

        /// <summary>
        /// Gets or sets the user group.
        /// </summary>
        public virtual Scope Scope { get; set; }
    }
}
