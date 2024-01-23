// <copyright file="ResourceVersion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System;
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource version.
    /// </summary>
    public partial class ResourceVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersion"/> class.
        /// </summary>
        public ResourceVersion()
        {
            this.ResourceVersionAuthor = new HashSet<ResourceVersionAuthor>();
            this.ResourceVersionKeyword = new HashSet<ResourceVersionKeyword>();
            this.ResourceVersionEvent = new HashSet<ResourceVersionEvent>();
            this.ResourceVersionFlag = new HashSet<ResourceVersionFlag>();
            this.ResourceVersionRatings = new HashSet<ResourceVersionRating>();
            this.FileChunkDetail = new HashSet<FileChunkDetail>();
            this.ResourceVersionUserAcceptance = new HashSet<ResourceVersionUserAcceptance>();
            this.ResourceVersionProvider = new HashSet<ResourceVersionProvider>();
        }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the publication id.
        /// </summary>
        public int? PublicationId { get; set; }

        /// <summary>
        /// Gets or sets the major version.
        /// </summary>
        public int? MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the minor version.
        /// </summary>
        public int? MinorVersion { get; set; }

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
        /// Gets or sets the provider id.
        /// </summary>
        public int? ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the review date.
        /// </summary>
        public DateTimeOffset? ReviewDate { get; set; }

        /// <summary>
        /// Gets or sets the resource.
        /// </summary>
        public virtual Resource Resource { get; set; }

        /// <summary>
        /// Gets or sets the resource accessibility.
        /// </summary>
        public virtual ResourceAccessibilityEnum ResourceAccessibilityEnum { get; set; }

        /// <summary>
        /// Gets or sets the resource where current.
        /// </summary>
        public virtual Resource ResourceWhereCurrent { get; set; }

        /// <summary>
        /// Gets or sets the version status enum.
        /// </summary>
        public virtual VersionStatusEnum VersionStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the article resource version.
        /// </summary>
        public virtual ArticleResourceVersion ArticleResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the embedded resource version.
        /// </summary>
        public virtual EmbeddedResourceVersion EmbeddedResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the equipment resource version.
        /// </summary>
        public virtual EquipmentResourceVersion EquipmentResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the web link resource version.
        /// </summary>
        public virtual WebLinkResourceVersion WebLinkResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the generic file resource version.
        /// </summary>
        public virtual GenericFileResourceVersion GenericFileResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the image resource version.
        /// </summary>
        public virtual ImageResourceVersion ImageResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the video resource version.
        /// </summary>
        public virtual VideoResourceVersion VideoResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the audio resource version.
        /// </summary>
        public virtual AudioResourceVersion AudioResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the scorm resource version.
        /// </summary>
        public virtual ScormResourceVersion ScormResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the scorm resource version validation result.
        /// </summary>
        public virtual ResourceVersionValidationResult ResourceVersionValidationResult { get; set; }

        /// <summary>
        /// Gets or sets the case resource version.
        /// </summary>
        public virtual CaseResourceVersion CaseResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the assessment resource version.
        /// </summary>
        public virtual AssessmentResourceVersion AssessmentResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the resource version author.
        /// </summary>
        public virtual ICollection<ResourceVersionAuthor> ResourceVersionAuthor { get; set; }

        /// <summary>
        /// Gets or sets the resource version keyword.
        /// </summary>
        public virtual ICollection<ResourceVersionKeyword> ResourceVersionKeyword { get; set; }

        /// <summary>
        /// Gets or sets the resource version event.
        /// </summary>
        public virtual ICollection<ResourceVersionEvent> ResourceVersionEvent { get; set; }

        /// <summary>
        /// Gets or sets the resource version flag.
        /// </summary>
        public virtual ICollection<ResourceVersionFlag> ResourceVersionFlag { get; set; }

        /// <summary>
        /// Gets or sets the publication.
        /// </summary>
        public virtual Publication Publication { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has cost.
        /// </summary>
        public bool HasCost { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        public decimal? Cost { get; set; }

        /// <summary>
        /// Gets or sets the resource licence id.
        /// </summary>
        public int? ResourceLicenceId { get; set; }

        /// <summary>
        /// Gets or sets the resource licence.
        /// </summary>
        public virtual ResourceLicence ResourceLicence { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sensitive content flag is set.
        /// </summary>
        public bool SensitiveContent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether certificate flag is set.
        /// </summary>
        public bool? CertificateEnabled { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the resource version ratings.
        /// </summary>
        public virtual ICollection<ResourceVersionRating> ResourceVersionRatings { get; set; }

        /// <summary>
        /// Gets or sets the resource version rating summary.
        /// </summary>
        public virtual ResourceVersionRatingSummary ResourceVersionRatingSummary { get; set; }

        /// <summary>
        /// Gets or sets the file chunk details.
        /// </summary>
        public virtual ICollection<FileChunkDetail> FileChunkDetail { get; set; }

        /// <summary>
        /// Gets or sets the resource version user acceptance.
        /// </summary>
        public virtual ICollection<ResourceVersionUserAcceptance> ResourceVersionUserAcceptance { get; set; }

        /// <summary>
        /// Gets or sets the resource version provider.
        /// </summary>
        public virtual ICollection<ResourceVersionProvider> ResourceVersionProvider { get; set; }
    }
}
