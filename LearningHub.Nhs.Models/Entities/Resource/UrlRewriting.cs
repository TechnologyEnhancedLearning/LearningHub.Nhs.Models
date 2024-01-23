// <copyright file="UrlRewriting.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// Defines the <see cref="UrlRewriting" />.
    /// </summary>
    public partial class UrlRewriting : EntityBase
    {
        /// <summary>
        /// Gets or sets the ExternalReferenceId.
        /// </summary>
        public int ExternalReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the FullHistoricUrl.
        /// </summary>
        public string FullHistoricUrl { get; set; }

        /// <summary>
        /// Gets or sets the PackageRootUrl.
        /// This is the part of the URL that gives us the root of the package stored in LH.
        /// Calculated by removing the ManifestURL from the end of the FullHistoricUrl.
        /// </summary>
        public string PackageRootUrl { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReference.
        /// </summary>
        public virtual ExternalReference ExternalReference { get; set; }
    }
}
