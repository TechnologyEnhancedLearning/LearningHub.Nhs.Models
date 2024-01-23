// <copyright file="RestrictedCatalogueSummaryViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The RestrictedCatalogueSummaryViewModel class.
    /// </summary>
    public class RestrictedCatalogueSummaryViewModel
    {
        /// <summary>
        /// Gets or sets the user-user group id.
        /// </summary>
        [Key]
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the user count.
        /// </summary>
        public int UserCount { get; set; }

        /// <summary>
        /// Gets or sets the access request count.
        /// </summary>
        public int AccessRequestCount { get; set; }
    }
}
