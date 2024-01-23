// <copyright file="ResourceVersionEventTypeEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The resource version event type enum.
    /// </summary>
    public enum ResourceVersionEventTypeEnum
    {
        /// <summary>
        /// The created draft.
        /// </summary>
        CreatedDraft = 1,

        /// <summary>
        /// The published.
        /// </summary>
        Published = 2,

        /// <summary>
        /// The unpublished.
        /// </summary>
        Unpublished = 3,

        /// <summary>
        /// The publishing.
        /// </summary>
        Publishing = 4,

        /// <summary>
        /// The admin event type.
        /// </summary>
        Admin = 5,

        /// <summary>
        /// The unpublished by admin event type.
        /// </summary>
        UnpublishedByAdmin = 6,

        /// <summary>
        /// The processing event type for a draft not yet published.
        /// </summary>
        DraftProcessing = 7,

        /// <summary>
        /// The processing event type for a resource that has failed publishing.
        /// </summary>
        PublishFailure = 8,
    }
}
