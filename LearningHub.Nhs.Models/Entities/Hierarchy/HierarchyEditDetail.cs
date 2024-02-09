namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The hierarchy edit detail.
    /// </summary>
    public class HierarchyEditDetail : EntityBase
    {
        /// <summary>
        /// Gets or sets the hierarchy edit id.
        /// </summary>
        public int HierarchyEditId { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit detail type.
        /// </summary>
        public HierarchyEditDetailTypeEnum HierarchyEditDetailType { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit detail operation.
        /// </summary>
        public HierarchyEditDetailOperationEnum? HierarchyEditDetailOperation { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the parent node id.
        /// </summary>
        public int? ParentNodeId { get; set; }

        /// <summary>
        /// Gets or sets the node link id.
        /// </summary>
        public int? NodeLinkId { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int? DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit.
        /// </summary>
        public virtual HierarchyEdit HierarchyEdit { get; set; }
    }
}
