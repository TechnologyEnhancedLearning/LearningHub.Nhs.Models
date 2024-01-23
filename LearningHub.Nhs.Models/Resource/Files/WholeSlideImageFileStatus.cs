﻿// <copyright file="WholeSlideImageFileStatus.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Files
{
    /// <summary>
    /// Defines the <see cref="WholeSlideImageFileStatus" />.
    /// </summary>
    public enum WholeSlideImageFileStatus
    {
        /// <summary>
        /// Uploading.
        /// </summary>
        Uploading = 0,

        /// <summary>
        /// Queued for Processing.
        /// </summary>
        QueuedForProcessing = 1,

        /// <summary>
        /// Processing Complete.
        /// </summary>
        ProcessingComplete = 2,

        /// <summary>
        /// Processing Failed.
        /// </summary>
        ProcessingFailed = 3,
    }
}