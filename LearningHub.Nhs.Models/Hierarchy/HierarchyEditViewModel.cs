namespace LearningHub.Nhs.Models.Hierarchy
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The hierarchy edit view model.
    /// </summary>
    public class HierarchyEditViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        [Key]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the hierarchy edit id.
        /// </summary>
        public int RootHierarchyEditDetailId { get; set; }

        /// <summary>
        /// Gets or sets the Node Name.
        /// </summary>
        public string NodeName { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the LastPublishedDate.
        /// </summary>
        public DateTimeOffset? LastPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the CreateDate.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the HierarchyEditStatus.
        /// </summary>
        public HierarchyEditStatusEnum HierarchyEditStatus { get; set; }
    }
}
