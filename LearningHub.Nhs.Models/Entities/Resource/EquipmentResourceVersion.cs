namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The equipment resource version.
    /// </summary>
    public partial class EquipmentResourceVersion : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact telephone.
        /// </summary>
        public string ContactTelephone { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the address id.
        /// </summary>
        public int? AddressId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
