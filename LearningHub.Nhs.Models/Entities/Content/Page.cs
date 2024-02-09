namespace LearningHub.Nhs.Models.Entities.Content
{
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="Page" />.
    /// </summary>
    public class Page : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Page"/> class.
        /// </summary>
        public Page()
        {
            this.PageSections = new HashSet<PageSection>();
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the PageSections.
        /// </summary>
        public virtual ICollection<PageSection> PageSections { get; set; }
    }
}
