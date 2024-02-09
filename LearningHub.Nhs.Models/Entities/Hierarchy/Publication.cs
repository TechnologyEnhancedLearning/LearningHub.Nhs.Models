namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The publication.
    /// </summary>
    public class Publication : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Publication"/> class.
        /// </summary>
        public Publication()
        {
            this.PublicationLog = new HashSet<PublicationLog>();
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int? NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the resource version has been Submitted To Search.
        /// </summary>
        public bool SubmittedToSearch { get; set; }

        /// <summary>
        /// Gets or sets the node version.
        /// </summary>
        public virtual NodeVersion NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the publication log.
        /// </summary>
        public virtual ICollection<PublicationLog> PublicationLog { get; set; }
    }
}
