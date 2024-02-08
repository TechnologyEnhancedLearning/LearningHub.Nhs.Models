namespace LearningHub.Nhs.Models.Hierarchy
{
    using System;

    /// <summary>
    /// The folder view model.
    /// </summary>
    public class FolderViewModel
    {
        /// <summary>
        /// Gets or sets the FolderNodeVersionId.
        /// </summary>
        public int FolderNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the NodeVersionId.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        public DateTime LastModifiedDate { get; set; }
    }
}
