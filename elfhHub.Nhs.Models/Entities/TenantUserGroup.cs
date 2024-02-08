namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The tenant user group.
    /// </summary>
    public class TenantUserGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }
    }
}
