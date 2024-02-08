namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The attribute.
    /// </summary>
    public class Attribute : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Attribute"/> class.
        /// </summary>
        public Attribute()
        {
            this.UserAttributes = new HashSet<UserAttribute>();
        }

        /// <summary>
        /// Gets or sets the attribute type id.
        /// </summary>
        public int AttributeTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the attribute type.
        /// </summary>
        public virtual AttributeType AttributeType { get; set; }

        /// <summary>
        /// Gets or sets the user attributes.
        /// </summary>
        public virtual ICollection<UserAttribute> UserAttributes { get; set; }
    }
}
