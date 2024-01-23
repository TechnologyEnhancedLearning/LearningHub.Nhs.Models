// <copyright file="CatalogueBasicViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    /// <summary>
    /// The Catalogue Basic ViewModel.
    /// </summary>
    public class CatalogueBasicViewModel
    {
        /// <summary>
        /// Gets or sets the CatalogueNodeVersion id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is hidden.
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the badge url.
        /// </summary>
        public string BadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted access.
        /// </summary>
        public bool RestrictedAccess { get; set; }
    }
}
