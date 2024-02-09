namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The entity base.
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the amend date.
        /// </summary>
        public DateTimeOffset AmendDate { get; set; }

        /// <summary>
        /// The is new.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsNew()
        {
            return this.Id == 0 && !this.Deleted;
        }
    }
}
