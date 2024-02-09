namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The resource type.
    /// </summary>
    public partial class ScormPackageType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScormPackageType"/> class.
        /// </summary>
        public ScormPackageType()
        {
            this.ScormResourceVersion = new HashSet<ScormResourceVersion>();
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
        /// Gets or sets the scorm resource version.
        /// </summary>
        public virtual ICollection<ScormResourceVersion> ScormResourceVersion { get; set; }
    }
}
