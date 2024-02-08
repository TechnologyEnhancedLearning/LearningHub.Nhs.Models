namespace LearningHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The provider.
    /// </summary>
    public class Provider : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Provider"/> class.
        /// </summary>
        public Provider()
        {
            this.ResourceVersionProvider = new HashSet<ResourceVersionProvider>();
            this.UserProvider = new HashSet<UserProvider>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the logo.
        /// </summary>
        public string Logo { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }

        /// <summary>
        /// Gets or sets the user provider.
        /// </summary>
        public virtual ICollection<UserProvider> UserProvider { get; set; }

        /// <summary>
        /// Gets or sets the resource version provider.
        /// </summary>
        public virtual ICollection<ResourceVersionProvider> ResourceVersionProvider { get; set; }
    }
}
