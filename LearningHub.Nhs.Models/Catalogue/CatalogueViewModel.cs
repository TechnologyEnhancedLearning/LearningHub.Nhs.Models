// <copyright file="CatalogueViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Binders;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Provider;
    using LearningHub.Nhs.Models.Validation;

    /// <summary>
    /// The Catalogue ViewModel.
    /// </summary>
    public class CatalogueViewModel : CatalogueBasicViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue node version id.
        /// </summary>
        public int CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public new string Url { get; set; }

        /// <summary>
        /// Gets or sets the catalogue card image url.
        /// </summary>
        public string CardImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the banner url.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the certificate url.
        /// </summary>
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [MaxLength(4000)]
        [SanitizedHtmlModelBinder]
        [RichTextLengthValidation(1800, ErrorMessage = "The description has a maximum length of 1800 characters.")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the owner email address.
        /// </summary>
        public string OwnerEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        [SanitizedHtmlModelBinder]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the last modified date.
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public VersionStatusEnum Status { get; set; }

        /// <summary>
        /// Gets or sets the resource order.
        /// </summary>
        public CatalogueOrder ResourceOrder { get; set; }

        /// <summary>
        /// Gets or sets the node path id.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue has a user group.
        /// </summary>
        public bool HasUserGroup { get; set; }

        /// <summary>
        ///  Gets or sets the BookmarkId.
        /// </summary>
        public int? BookmarkId { get; set; }

        /// <summary>
        ///  Gets or sets a value indicating whether gets or sets the IsBookmarked.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public ICollection<ProviderViewModel> Providers { get; set; }

        /// <summary>
        /// Gets or sets the CatalogueNodeVersionProvider.
        /// </summary>
        public virtual CatalogueNodeVersionProvider CatalogueNodeVersionProvider { get; set; }
    }
}
