// <copyright file="NodeViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The node view model.
    /// Populated by GetNodeDetails stored proc.
    /// </summary>
    public class NodeViewModel
    {
        /// <summary>
        /// Gets or sets the Node id.
        /// </summary>
        [Key]
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the NodePath id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the node name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the node description.
        /// </summary>
        public string Description { get; set; }
    }
}
