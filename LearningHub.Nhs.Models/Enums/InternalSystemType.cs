// <copyright file="InternalSystemType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The internal system type.
    /// </summary>
    public enum InternalSystemType
    {
        /// <summary>
        /// LearningHub.
        /// </summary>
        LearningHub = 1,

        /// <summary>
        /// ResourcePublishQueue.
        /// </summary>
        ResourcePublishQueue = 2,

        /// <summary>
        /// HierarchyEditpublishQueue.
        /// </summary>
        HierarchyEditpublishQueue = 3,

        /// <summary>
        /// ContentManagementQueue.
        /// </summary>
        ContentManagementQueue = 4,

        /// <summary>
        /// WholeSlideImageProcessingQueue.
        /// </summary>
        WholeSlideImageProcessingQueue = 5,

        /// <summary>
        /// WholeSlideImageProcessingJavaQueue.
        /// </summary>
        WholeSlideImageProcessingJavaQueue = 6,

        /// <summary>
        /// VideoProcessingQueue.
        /// </summary>
        VideoProcessingQueue = 7,
    }
}
