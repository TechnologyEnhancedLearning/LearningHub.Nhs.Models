namespace LearningHub.Nhs.Models.Entities
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The address.
    /// </summary>
    public partial class Address : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
            this.EquipmentResourceVersion = new HashSet<EquipmentResourceVersion>();
        }

        /// <summary>
        /// Gets or sets the address 1.
        /// </summary>
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address 2.
        /// </summary>
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the address 3.
        /// </summary>
        public string Address3 { get; set; }

        /// <summary>
        /// Gets or sets the address 4.
        /// </summary>
        public string Address4 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the equipment resource version.
        /// </summary>
        public virtual ICollection<EquipmentResourceVersion> EquipmentResourceVersion { get; set; }
    }
}
