namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The hierarchy edit.
    /// </summary>
    public class HierarchyEdit : EntityBase
    {
        /// <summary>
        /// Gets or sets the root node id.
        /// </summary>
        public int? RootNodeId { get; set; }

        /// <summary>
        /// Gets or sets the publication id.
        /// </summary>
        public int? PublicationId { get; set; }

        /// <summary>
        /// Gets or sets the root node.
        /// </summary>
        public virtual Node RootNode { get; set; }

        /// <summary>
        /// Gets or sets the publication.
        /// </summary>
        public virtual Publication Publication { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit status.
        /// </summary>
        public HierarchyEditStatusEnum HierarchyEditStatus { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit detail.
        /// </summary>
        public virtual ICollection<HierarchyEditDetail> HierarchyEditDetail { get; set; }
    }
}
