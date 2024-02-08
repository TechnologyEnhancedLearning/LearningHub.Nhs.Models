namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The staff group.
    /// </summary>
    public class StaffGroup : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether internal users only.
        /// </summary>
        public bool InternalUsersOnly { get; set; }
    }
}
