namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The region.
    /// </summary>
    public class Region : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
