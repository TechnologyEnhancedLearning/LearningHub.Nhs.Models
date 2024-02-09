namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource sync.
    /// </summary>
    public class ResourceSync : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        public virtual ResourceVersion Resource { get; set; }
    }
}
