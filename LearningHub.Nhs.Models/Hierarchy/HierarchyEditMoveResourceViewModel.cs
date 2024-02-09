namespace LearningHub.Nhs.Models.Hierarchy
{
    /// <summary>
    /// The hierarchy edit move resource view model.
    /// </summary>
    public class HierarchyEditMoveResourceViewModel
    {
        /// <summary>
        /// Gets or sets the HierarchyEditDetailId.
        /// </summary>
        public int HierarchyEditDetailId { get; set; }

        /// <summary>
        /// Gets or sets the 'Move to' HierarchyEditDetailId.
        /// </summary>
        public int MoveToHierarchyEditDetailId { get; set; }
    }
}
