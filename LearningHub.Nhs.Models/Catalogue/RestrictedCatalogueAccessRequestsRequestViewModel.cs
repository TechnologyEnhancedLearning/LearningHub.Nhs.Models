// <copyright file="RestrictedCatalogueAccessRequestsRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    /// <summary>
    /// The RestrictedCatalogueAccessRequestsRequestViewModel class.
    /// </summary>
    public class RestrictedCatalogueAccessRequestsRequestViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include new access requests.
        /// </summary>
        public bool IncludeNew { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include approved access requests.
        /// </summary>
        public bool IncludeApproved { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include new access requests.
        /// </summary>
        public bool IncludeDenied { get; set; }
    }
}
