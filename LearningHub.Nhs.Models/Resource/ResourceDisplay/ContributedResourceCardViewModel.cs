// <copyright file="ContributedResourceCardViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.ViewModels.Helpers;

    /// <summary>
    /// The resource card view model.
    /// </summary>
    public class ContributedResourceCardViewModel
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
        /// Gets or sets the resource accessibility enumeration.
        /// </summary>
        public ResourceAccessibilityEnum ResourceAccessibilityEnum { get; set; }

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
        /// Gets a value indicating whether an action is required.
        /// </summary>
        public bool ActionRequired =>
            (this.VersionStatusEnum == Enums.VersionStatusEnum.Unpublished
            && this.UnpublishedByAdmin)
             ||
            (this.VersionStatusEnum == Enums.VersionStatusEnum.Published
            && this.IsFlagged)
            ||
            (this.VersionStatusEnum == Enums.VersionStatusEnum.FailedToPublish);

        /// <summary>
        /// Gets a value indicating whether card is a 'draft'.
        /// </summary>
        public bool DraftCategory => this.VersionStatusEnum == VersionStatusEnum.Draft; // && !this.PreviousPublishedStatusEnum.HasValue;

        /// <summary>
        /// Gets a value indicating whether card is considered 'published'.
        /// </summary>
        public bool PublishedCategory => this.VersionStatusEnum == VersionStatusEnum.Published
            || (this.VersionStatusEnum == VersionStatusEnum.Publishing)
            || (this.VersionStatusEnum == VersionStatusEnum.SubmittedToPublishingQueue);

        /// <summary>
        /// Gets a value indicating whether card is considered 'unpublished'.
        /// </summary>
        public bool UnpublishedCategory => this.VersionStatusEnum == VersionStatusEnum.Unpublished;

        /// <summary>
        /// Gets or sets a value indicating whether in edit.
        /// </summary>
        public bool InEdit { get; set; }

        /// <summary>
        /// Gets or sets the draft resource version id.
        /// </summary>
        public int DraftResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is flagged.
        /// </summary>
        public bool IsFlagged { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether flagged by admin.
        /// </summary>
        public bool FlaggedByAdmin { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the published date.
        /// </summary>
        public DateTime PublishedDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether unpublished by admin.
        /// </summary>
        public bool UnpublishedByAdmin { get; set; }

        /// <summary>
        /// Gets the contributed on formatted date.
        /// </summary>
        public string ContributedOn =>
            this.VersionStatusEnum == VersionStatusEnum.Published
                ? this.PublishedDate.ToString("dd MMMM yyyy")
                : this.CreatedDate.ToString("dd MMMM yyyy");

        /// <summary>
        /// Gets or sets a value indicating whether card is read only.
        /// </summary>
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has validation errors.
        /// </summary>
        public bool HasValidationErrors { get; set; }
    }
}
