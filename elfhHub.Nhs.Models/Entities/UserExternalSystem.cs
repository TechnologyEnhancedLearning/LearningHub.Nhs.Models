namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// ExternalSystem.
    /// </summary>
    public class UserExternalSystem : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the external system id.
        /// </summary>
        public int ExternalSystemId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the external system.
        /// </summary>
        public virtual ExternalSystem ExternalSystem { get; set; }
    }
}