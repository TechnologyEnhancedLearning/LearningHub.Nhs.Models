// <copyright file="NodePathNodeViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The node path node view model. Basic node details.
    /// Populated by GetNodePathNodes stored proc.
    /// </summary>
    public class NodePathNodeViewModel
    {
        /// <summary>
        /// Gets or sets the Node id.
        /// </summary>
        [Key]
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the node name.
        /// </summary>
        public string Name { get; set; }
    }
}
