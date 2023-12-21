// <copyright file="NodePathDisplay.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The node path display.
    /// </summary>
    public class NodePathDisplay : EntityBase
    {
        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the node path.
        /// </summary>
        public virtual NodePath NodePath { get; set; }
    }
}
