namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user history attribute.
    /// </summary>
    public class UserHistoryAttribute : EntityBase
    {
        /// <summary>
        /// Gets or sets the user history id.
        /// </summary>
        public int UserHistoryId { get; set; }

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
        /// Gets or sets the user history.
        /// </summary>
        public virtual UserHistory UserHistory { get; set; }
    }
}
