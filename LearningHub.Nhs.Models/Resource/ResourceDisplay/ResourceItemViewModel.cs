// <copyright file="ResourceItemViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using LearningHub.Nhs.Models.Catalogue;

    /// <summary>
    /// The resource item view model.
    /// </summary>
    public class ResourceItemViewModel : ResourceVersionExtendedViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceItemViewModel"/> class.
        /// </summary>
        public ResourceItemViewModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceItemViewModel"/> class.
        /// </summary>
        /// <param name="source">Base source for ResourceItemViewModel.</param>
        public ResourceItemViewModel(ResourceVersionExtendedViewModel source)
        {
            this.AdditionalInformation = source.AdditionalInformation;
            this.ArticleDetails = source.ArticleDetails;
            this.AudioDetails = source.AudioDetails;
            this.AuthoredDate = source.AuthoredDate;
            this.Authors = source.Authors;
            this.Cost = source.Cost;
            this.CreateDate = source.CreateDate;
            this.CreateUser = source.CreateUser;
            this.CreateUserId = source.CreateUserId;
            this.Description = source.Description;
            this.EmbedCodeDetails = source.EmbedCodeDetails;
            this.EquipmentDetails = source.EquipmentDetails;
            this.FirstPublishedDate = source.FirstPublishedDate;
            this.Flags = source.Flags;
            this.GenericFileDetails = source.GenericFileDetails;
            this.ImageDetails = source.ImageDetails;
            this.Keywords = source.Keywords;
            this.LicenseName = source.LicenseName;
            this.LicenseUrl = source.LicenseUrl;
            this.MajorVersion = source.MajorVersion;
            this.MinorVersion = source.MinorVersion;
            this.NextReviewDate = source.NextReviewDate;
            this.PublishedBy = source.PublishedBy;
            this.PublishedDate = source.PublishedDate;
            this.PublishedNotes = source.PublishedNotes;
            this.ResourceFree = source.ResourceFree;
            this.ResourceId = source.ResourceId;
            this.ResourceTypeEnum = source.ResourceTypeEnum;
            this.ResourceVersionId = source.ResourceVersionId;
            this.ScormDetails = source.ScormDetails;
            this.SensitiveContent = source.SensitiveContent;
            this.CertificateEnabled = source.CertificateEnabled;
            this.Title = source.Title;
            this.UnpublishedByAdmin = source.UnpublishedByAdmin;
            this.VersionStatusEnum = source.VersionStatusEnum;
            this.VideoDetails = source.VideoDetails;
            this.WebLinkDetails = source.WebLinkDetails;
            this.Providers = source.Providers;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the NodePathId.
        /// </summary>
        public int NodePathId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item should be shown as ReadOnly.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the catalogue.
        /// </summary>
        public CatalogueViewModel Catalogue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the item should be shown with 'contributor' display.
        /// </summary>
        public bool DisplayForContributor { get; set; }

        /// <summary>
        /// Gets or sets the resource version id of any associated existing draft.
        /// </summary>
        public int ResourceVersionIdInEdit { get; set; }

        /// <summary>
        /// Gets or sets the resource version id of any associated existing draft.
        /// </summary>
        public int ResourceVersionIdPublishing { get; set; }
    }
}
