namespace LearningHub.Nhs.Models.Entities
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The attribute.
    /// </summary>
    public partial class Attribute : EntityBase
    {
        /// <summary>
        /// Gets or sets the attribute type enum.
        /// </summary>
        public virtual AttributeTypeEnum AttributeTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
