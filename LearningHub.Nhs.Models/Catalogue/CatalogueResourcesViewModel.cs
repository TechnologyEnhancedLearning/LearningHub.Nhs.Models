// <copyright file="CatalogueResourcesViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using LearningHub.Nhs.Models.Common;
    using LearningHub.Nhs.Models.Resource;

    /// <summary>
    /// The CatalogueResourcesViewModel.
    /// </summary>
    public class CatalogueResourcesViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        public PagedResultSet<ResourceAdminSearchResultViewModel> Resources { get; set; }
    }
}
