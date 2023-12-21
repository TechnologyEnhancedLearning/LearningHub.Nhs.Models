// <copyright file="CatalogueResourceResponseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System.Collections.Generic;

    /// <summary>
    /// CatalogueResourceResponseViewModel.
    /// </summary>
    public class CatalogueResourceResponseViewModel
    {
        /// <summary>
        /// Gets or sets nodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets total resources.
        /// </summary>
        public int TotalResources { get; set; }

        /// <summary>
        /// Gets or sets CatalogueResources.
        /// </summary>
        public List<CatalogueResourceViewModel> CatalogueResources { get; set; }
    }
}
