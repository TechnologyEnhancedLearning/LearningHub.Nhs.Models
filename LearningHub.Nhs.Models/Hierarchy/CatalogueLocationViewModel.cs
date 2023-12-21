// <copyright file="CatalogueLocationViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The catalogue location view model.
    /// </summary>
    public class CatalogueLocationViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        [Key]
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the resource count.
        /// </summary>
        public int ResourceCount { get; set; }
    }
}
