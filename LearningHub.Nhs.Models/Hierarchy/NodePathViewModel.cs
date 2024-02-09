namespace LearningHub.Nhs.Models.Hierarchy
{
    /// <summary>
    /// The node path view model.
    /// </summary>
    public class NodePathViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the node path string.
        /// </summary>
        public string NodePathString { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the node path is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int CatalogueNodeId { get; set; }
    }
}
