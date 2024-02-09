namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user attribute.
    /// </summary>
    public class UserAttribute : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAttribute"/> class.
        /// </summary>
        public UserAttribute()
        {
        }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the attribute id.
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// Gets or sets the int value.
        /// </summary>
        public int? IntValue { get; set; }

        /// <summary>
        /// Gets or sets the text value.
        /// </summary>
        public string TextValue { get; set; }

        /// <summary>
        /// Gets or sets the boolean value.
        /// </summary>
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// Gets or sets the date value.
        /// </summary>
        public DateTimeOffset? DateValue { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the attribute.
        /// </summary>
        public virtual Attribute Attribute { get; set; }
    }
}
