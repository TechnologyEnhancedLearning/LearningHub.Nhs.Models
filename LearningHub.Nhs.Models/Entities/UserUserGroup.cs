namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The user user group.
    /// </summary>
    public partial class UserUserGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the user group.
        /// </summary>
        public virtual UserGroup UserGroup { get; set; }
    }
}
