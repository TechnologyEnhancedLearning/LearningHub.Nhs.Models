// <copyright file="ResourceDetailViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Contribute
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Binders;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Validation;

    /// <summary>
    /// The resource detail view model.
    /// </summary>
    public class ResourceDetailViewModel : ResourceViewModel
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [MaxLength(4000)]
        [RichTextLengthValidation(1800, ErrorMessage = "The description has a maximum length of 1800 characters.")]
        [SanitizedHtmlModelBinder]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the licence id.
        /// </summary>
        public int? ResourceLicenceId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue id.
        /// </summary>
        public int? ResourceCatalogueId { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the published catalogue id.
        /// </summary>
        public int? PublishedResourceCatalogueId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sensitive content flag is set.
        /// </summary>
        public bool SensitiveContent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether certificate flag is set.
        /// </summary>
        public bool? CertificateEnabled { get; set; }

        /// <summary>
        /// Gets or sets the created user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the resource provider id.
        /// </summary>
        public int? ResourceProviderId { get; set; }

        /// <summary>
        /// Gets or sets the resource licence.
        /// </summary>
        public ResourceLicenceViewModel ResourceLicence { get; set; }

        /// <summary>
        /// Gets or sets the version status enum.
        /// </summary>
        public VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the resource accessibility.
        /// </summary>
        public ResourceAccessibilityEnum ResourceAccessibilityEnum { get; set; }

        /// <summary>
        /// Gets or sets the current resource version id.
        /// </summary>
        public VersionStatusEnum? CurrentResourceVersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the resource authors.
        /// </summary>
        public ICollection<ResourceAuthorViewModel> ResourceAuthors { get; set; }

        /// <summary>
        /// Gets or sets the resource keywords.
        /// </summary>
        public ICollection<ResourceKeywordViewModel> ResourceKeywords { get; set; }

        /// <summary>
        /// Gets or sets the flags.
        /// </summary>
        public ICollection<ResourceVersionFlagViewModel> Flags { get; set; }
    }
}
