namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The ActivityStatus.
    /// </summary>
    public partial class MediaResourceActivityType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaResourceActivityType"/> class.
        /// </summary>
        public MediaResourceActivityType()
        {
            this.MediaResourceActivityInteraction = new HashSet<MediaResourceActivityInteraction>();
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the MediaResourceActivityInteraction.
        /// </summary>
        public virtual ICollection<MediaResourceActivityInteraction> MediaResourceActivityInteraction { get; set; }
    }
}
