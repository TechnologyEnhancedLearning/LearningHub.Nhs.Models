namespace LearningHub.Nhs.Models.Hierarchy
{
    /// <summary>
    /// The folder edit view model.
    /// </summary>
    public class FolderEditViewModel
    {
        /// <summary>
        /// Gets or sets the HierarchyEditId.
        /// </summary>
        public int HierarchyEditId { get; set; }

        /// <summary>
        /// Gets or sets the HierarchyEditDetailId.
        /// </summary>
        public int? HierarchyEditDetailId { get; set; }

        /// <summary>
        /// Gets or sets the NodeVersionId.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the Parent Node Id.
        /// </summary>
        public int ParentNodeId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }
    }
}
