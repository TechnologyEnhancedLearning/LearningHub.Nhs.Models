namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The tenant url.
    /// </summary>
    public class TenantUrl : EntityBase
    {
        /// <summary>
        /// Gets or sets the url host name.
        /// </summary>
        public string UrlHostName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether use host for auth.
        /// </summary>
        public bool UseHostForAuth { get; set; }

        /// <summary>
        /// Gets or sets the tenant id.
        /// </summary>
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or sets the tenant.
        /// </summary>
        public virtual Tenant Tenant { get; set; }
    }
}