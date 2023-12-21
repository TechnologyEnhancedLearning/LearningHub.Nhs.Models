// <copyright file="Scope.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The scope.
    /// </summary>
    public partial class Scope : EntityBase
    {
        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int? CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the scope type.
        /// </summary>
        public ScopeTypeEnum ScopeType { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node.
        /// </summary>
        public virtual Node CatalogueNode { get; set; }
    }
}
