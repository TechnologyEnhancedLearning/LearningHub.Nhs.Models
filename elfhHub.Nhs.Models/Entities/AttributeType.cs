// <copyright file="AttributeType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The attribute type.
    /// </summary>
    public class AttributeType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeType"/> class.
        /// </summary>
        public AttributeType()
        {
            this.Attributes = new HashSet<Attribute>();
        }

        /// <summary>
        /// Gets or sets the type name.
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        public virtual ICollection<Attribute> Attributes { get; set; }
    }
}
