namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The notification type.
    /// </summary>
    public partial class NotificationType : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}