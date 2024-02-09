namespace LearningHub.Nhs.Models.Entities.External
{
    /// <summary>
    /// The external system user entity.
    /// </summary>
    public class ExternalSystemUser : EntityBase
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
        /// Gets or sets the external system.
        /// </summary>
        public virtual ExternalSystem ExternalSystem { get; set; }
    }
}