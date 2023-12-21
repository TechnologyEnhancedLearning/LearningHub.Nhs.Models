// <copyright file="MoveNodeViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    /// <summary>
    /// The move node view model.
    /// </summary>
    public class MoveNodeViewModel
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
