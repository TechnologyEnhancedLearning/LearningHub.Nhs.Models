// <copyright file="CacheOperationViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The cache operation view model.
    /// IT1 - only caters for Node refresh operations resulting from changes to Node-Resource associations.
    /// </summary>
    public class CacheOperationViewModel
    {
        /// <summary>
        /// Gets or sets the NodeId.
        /// </summary>
        [Key]
        public int NodeId { get; set; }
    }
}
