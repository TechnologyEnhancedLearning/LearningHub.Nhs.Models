namespace LearningHub.Nhs.Models.Entities.Activity
{
    /// <summary>
    /// NodeActivity.
    /// </summary>
    public class NodeActivity : EntityBase
    {
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the CatalogueNodeVersionId.
        /// </summary>
        public int CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the ActivityStatusId.
        /// </summary>
        public int ActivityStatusId { get; set; }
    }
}
