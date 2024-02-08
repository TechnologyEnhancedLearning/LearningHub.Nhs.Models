namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The ActivityStatus.
    /// </summary>
    public partial class ActivityStatus : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityStatus"/> class.
        /// </summary>
        public ActivityStatus()
        {
            this.ResourceActivity = new HashSet<ResourceActivity>();
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ResourceActivity.
        /// </summary>
        public virtual ICollection<ResourceActivity> ResourceActivity { get; set; }
    }
}
