namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The system setting.
    /// </summary>
    public class SystemSetting : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

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
    }
}
