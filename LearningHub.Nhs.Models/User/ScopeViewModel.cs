// <copyright file="ScopeViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.User
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The scope view model.
    /// </summary>
    public partial class ScopeViewModel
    {
        /// <summary>
        /// Gets or sets the scope id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int? CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the scope type.
        /// </summary>
        public ScopeTypeEnum ScopeType { get; set; }
    }
}
