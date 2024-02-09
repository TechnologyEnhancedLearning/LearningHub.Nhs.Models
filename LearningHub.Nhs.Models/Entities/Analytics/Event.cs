namespace LearningHub.Nhs.Models.Entities.Analytics
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The event.
    /// </summary>
    public partial class Event : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the json data.
        /// </summary>
        public string JsonData { get; set; }

        /// <summary>
        /// Gets or sets the event type enum.
        /// </summary>
        public virtual EventTypeEnum EventTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the group id.
        /// </summary>
        public virtual Guid GroupId { get; set; }
    }
}
