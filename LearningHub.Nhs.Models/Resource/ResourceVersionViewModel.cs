namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Provider;
    using LearningHub.Nhs.Models.ViewModels.Helpers;

    /// <summary>
    /// The resource version view model.
    /// </summary>
    public class ResourceVersionViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the default resource reference id.
        /// </summary>
        public int DefaultResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource type enumeration.
        /// </summary>
        public ResourceTypeEnum ResourceTypeEnum { get; set; }

        /// <summary>
        /// Gets the resource type description.
        /// </summary>
        public string ResourceTypeDescription => ResourceHelper.GetResourceTypeDescription(this.ResourceTypeEnum);

        /// <summary>
        /// Gets or sets the version status enumeration.
        /// </summary>
        public VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets the version status description.
        /// </summary>
        public string VersionStatusDescription => ResourceHelper.GetResourceVersionStatusDescription(this.VersionStatusEnum);

        /// <summary>
        /// Gets or sets the major version.
        /// </summary>
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the minor version.
        /// </summary>
        public int? MinorVersion { get; set; }

        /// <summary>
        /// Gets the version description.
        /// </summary>
        public string VersionDescription
        {
            get
            {
                if (this.MajorVersion.HasValue || this.MinorVersion.HasValue)
                {
                    return string.Format("{0}.{1}", this.MajorVersion.Value.ToString(), this.MinorVersion.Value.ToString());
                }
                else
                {
                    return null;
                }
            }
         }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        public string AdditionalInformation { get; set; }

        /// <summary>
        /// Gets or sets the next review date.
        /// </summary>
        public DateTime NextReviewDate { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the authors.
        /// </summary>
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the authored date.
        /// </summary>
        public DateTime AuthoredDate { get; set; }

        /// <summary>
        /// Gets or sets the published by.
        /// </summary>
        public string PublishedBy { get; set; }

        /// <summary>
        /// Gets or sets the published notes.
        /// </summary>
        public string PublishedNotes { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets the first published date.
        /// </summary>
        public DateTime FirstPublishedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unpublished by admin.
        /// </summary>
        public bool UnpublishedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether resource free.
        /// </summary>
        public bool ResourceFree { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public double Cost { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sensitive content flag is set.
        /// </summary>
        public bool SensitiveContent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether certificate flag is set.
        /// </summary>
        public bool? CertificateEnabled { get; set; }

        /// <summary>
        /// Gets or sets the flags.
        /// </summary>
        public ICollection<ResourceVersionFlagViewModel> Flags { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user n.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the license name.
        /// </summary>
        public string LicenseName { get; set; }

        /// <summary>
        /// Gets or sets the license url.
        /// </summary>
        public string LicenseUrl { get; set; }

        /// <summary>
        /// Gets or sets the BookmarkId.
        /// </summary>
        public int? BookmarkId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsBookmarked.
        /// </summary>
        public bool IsBookmarked { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has validation errors.
        /// </summary>
        public bool HasValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the resource accessibility.
        /// </summary>
        public ResourceAccessibilityEnum ResourceAccessibilityEnum { get; set; }

        /// <summary>
        /// Gets or sets the providers.
        /// </summary>
        public List<ProviderViewModel> Providers { get; set; }
    }
}
