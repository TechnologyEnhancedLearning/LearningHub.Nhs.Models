// <copyright file="ResourceAdminSearchResultViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.ViewModels.Helpers;

    /// <summary>
    /// The resource version view model.
    /// </summary>
    public class ResourceAdminSearchResultViewModel
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
        /// Gets or sets the resource id.
        /// </summary>
        public List<int> ResourceReferenceIds { get; set; }

        /// <summary>
        /// Gets the resource id list.
        /// </summary>
        public string ResourceReferenceIdList
        {
            get
            {
                return (this.ResourceReferenceIds == null) ? string.Empty : string.Join(",", this.ResourceReferenceIds.Select(n => n.ToString()).ToArray());
            }
        }

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
        /// Gets the full version details.
        /// </summary>
        public string VersionFullDetails => this.VersionStatusDescription + (string.IsNullOrEmpty(this.VersionDescription) ? string.Empty : $" ({this.VersionDescription})");

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create user n.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether marked for sync.
        /// </summary>
        public bool MarkedForSync { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }
    }
}
