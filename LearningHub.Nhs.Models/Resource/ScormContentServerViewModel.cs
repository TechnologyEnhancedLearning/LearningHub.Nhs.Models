// <copyright file="ScormContentServerViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="ScormContentServerViewModel" />.
    /// </summary>
    public class ScormContentServerViewModel
    {
        /// <summary>
        /// Gets or sets the InternalResourceIdentifier.
        /// </summary>
        [Key]
        public string InternalResourceIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the ManifestUrl.
        /// </summary>
        public string ManifestUrl { get; set; }

        /// <summary>
        /// Gets or sets the Title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the EsrLinkType
        /// Gets or sets a value indicating EsrLinkType..
        /// </summary>
        public EsrLinkType EsrLinkType { get; set; }

        /// <summary>
        /// Gets or sets the VersionStatus.
        /// </summary>
        public VersionStatusEnum VersionStatus { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsActive.
        /// </summary>
        public bool IsActive { get; set; }
    }
}
