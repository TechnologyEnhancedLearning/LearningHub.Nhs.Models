namespace LearningHub.Nhs.Models.Entities.Analytics
{
    using System.Collections.Generic;

    /// <summary>
    /// The event type.
    /// </summary>
    public partial class EventType : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventType"/> class.
        /// </summary>
        public EventType()
        {
            this.Event = new HashSet<Event>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the dedscription.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the event.
        /// </summary>
        public virtual ICollection<Event> Event { get; set; }
    }
}
