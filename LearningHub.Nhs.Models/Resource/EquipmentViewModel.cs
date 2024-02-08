namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The equipment view model.
    /// </summary>
    public class EquipmentViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public AddressViewModel Address { get; set; }

        /// <summary>
        /// Gets or sets the contact name.
        /// </summary>
        public string ContactName { get; set; }

        /// <summary>
        /// Gets or sets the contact email.
        /// </summary>
        public string ContactEmail { get; set; }

        /// <summary>
        /// Gets or sets the contact telephone.
        /// </summary>
        public string ContactTelephone { get; set; }
    }
}