namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user group type input validation.
    /// </summary>
    public class UserGroupTypeInputValidation : EntityBase
    {
        /// <summary>
        /// Gets or sets the user group id.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the user group type prefix.
        /// </summary>
        public string UserGroupTypePrefix { get; set; }

        /// <summary>
        /// Gets or sets the user group type id.
        /// </summary>
        public int UserGroupTypeId { get; set; }

        /// <summary>
        /// Gets or sets the validation text value.
        /// </summary>
        public string ValidationTextValue { get; set; }

        /// <summary>
        /// Gets or sets the validation method.
        /// </summary>
        public int ValidationMethod { get; set; }

        /// <summary>
        /// Gets or sets the created user id.
        /// </summary>
        public int CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }
    }
}
