namespace LearningHub.Nhs.Models.Entities.Reporting
{
    using System;

    /// <summary>
    /// The Client class.
    /// </summary>
    public class Client : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }
    }
}
