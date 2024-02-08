namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The resource type.
    /// </summary>
    public partial class ResourceType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceType"/> class.
        /// </summary>
        public ResourceType()
        {
            this.FileType = new HashSet<FileType>();
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
        /// Gets or sets the file type.
        /// </summary>
        public virtual ICollection<FileType> FileType { get; set; }
    }
}
