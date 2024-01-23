// <copyright file="ResourceHelper.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.ViewModels.Helpers
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource helper.
    /// </summary>
    public class ResourceHelper
    {
        /// <summary>
        /// The get resource version event type description.
        /// </summary>
        /// <param name="eventTypeEnum">
        /// The event type enum.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetResourceVersionEventTypeDescription(ResourceVersionEventTypeEnum eventTypeEnum)
        {
            string description = string.Empty;
            switch (eventTypeEnum)
            {
                case ResourceVersionEventTypeEnum.CreatedDraft:
                    description = "Created Draft";
                    break;
                case ResourceVersionEventTypeEnum.Published:
                    description = "Published";
                    break;
                case ResourceVersionEventTypeEnum.Unpublished:
                    description = "Unpublished";
                    break;
            }

            return description;
        }

        /// <summary>
        /// The get resource version status description.
        /// </summary>
        /// <param name="versionStatusEnum">
        /// The version status enum.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetResourceVersionStatusDescription(VersionStatusEnum versionStatusEnum)
        {
            string description = string.Empty;
            switch (versionStatusEnum)
            {
                case VersionStatusEnum.Draft:
                    description = "Draft";
                    break;
                case VersionStatusEnum.Published:
                    description = "Published";
                    break;
                case VersionStatusEnum.Publishing:
                    description = "Publishing";
                    break;
                case VersionStatusEnum.Unpublished:
                    description = "Unpublished";
                    break;
                case VersionStatusEnum.SubmittedToPublishingQueue:
                    description = "Submitted to Queue";
                    break;
                case VersionStatusEnum.FailedToPublish:
                    description = "Publish Failed";
                    break;
            }

            return description;
        }

        /// <summary>
        /// The get resource type description.
        /// </summary>
        /// <param name="resourceTypeEnum">
        /// The resource type enum.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string GetResourceTypeDescription(ResourceTypeEnum resourceTypeEnum)
        {
            string description = string.Empty;

            switch (resourceTypeEnum)
            {
                case ResourceTypeEnum.Undefined:
                    description = "Undefined";
                    break;
                case ResourceTypeEnum.Assessment:
                    description = "Assessment";
                    break;
                case ResourceTypeEnum.Article:
                    description = "Article";
                    break;
                case ResourceTypeEnum.Audio:
                    description = "Audio";
                    break;
                case ResourceTypeEnum.Embedded:
                    description = "Embedded";
                    break;
                case ResourceTypeEnum.Equipment:
                    description = "Equipment";
                    break;
                case ResourceTypeEnum.Image:
                    description = "Image";
                    break;
                case ResourceTypeEnum.Scorm:
                    description = "Scorm 1.2";
                    break;
                case ResourceTypeEnum.Video:
                    description = "Video";
                    break;
                case ResourceTypeEnum.WebLink:
                    description = "WebLink";
                    break;
                case ResourceTypeEnum.GenericFile:
                    description = "File";
                    break;
                case ResourceTypeEnum.Case:
                    description = "Case";
                    break;
                default:
                    break;
            }

            return description;
        }
    }
}
