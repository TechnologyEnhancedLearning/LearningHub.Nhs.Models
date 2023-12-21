// <copyright file="ResourceContributionsRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    /// <summary>
    /// The resource contributions request view model.
    /// </summary>
    public class ResourceContributionsRequestViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue node id.
        /// </summary>
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the status id.
        /// </summary>
        public int StatusId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether restricted to current user.
        /// </summary>
        public bool RestrictToCurrentUser { get; set; }

        /// <summary>
        /// Gets or sets the offset number.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the quantity of records required.
        /// </summary>
        public int Take { get; set; }
    }
}
