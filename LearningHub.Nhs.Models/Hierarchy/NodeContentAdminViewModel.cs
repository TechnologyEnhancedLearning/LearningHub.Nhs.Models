namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The node content admin view model.
    /// </summary>
    public class NodeContentAdminViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the NodeTypeId.
        /// </summary>
        public int NodeTypeId { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the NodeVersionId.
        /// </summary>
        public int? NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int? ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersionId.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int? ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the DisplayOrder.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the ResourceTypeId.
        /// </summary>
        public int? ResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the VersionStatusId.
        /// </summary>
        public int? VersionStatusId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the resource was unpublished by admin, as opposed to the contributor.
        /// </summary>
        public bool? UnpublishedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the resource is currently being edited (existence of a draft version).
        /// </summary>
        public bool? ResourceInEdit { get; set; }

        /// <summary>
        /// Gets or sets the DraftResourceVersionId if the resource is in edit.
        /// </summary>
        public int? DraftResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Node has any resources under the immediate node.
        /// </summary>
        public bool HasResourcesInd { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Node has any resources anywhere in the branch under the node.
        /// </summary>
        public bool HasResourcesInBranchInd { get; set; }

        /// <summary>
        /// Gets or sets the HierarchyEditDetailId.
        /// </summary>
        public int? HierarchyEditDetailId { get; set; }
    }
}
