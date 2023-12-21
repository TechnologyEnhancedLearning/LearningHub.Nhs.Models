// <copyright file="PartialFilePostProcessingOptions.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Files
{
    /// <summary>
    /// Defines the <see cref="PartialFilePostProcessingOptions" />.
    /// </summary>
    public enum PartialFilePostProcessingOptions
    {
        /// <summary>
        /// No post-processing
        /// </summary>
        None = 0,

        /// <summary>
        /// Post-process file as whole-slide image into DeepZoom image file tree
        /// </summary>
        WholeSlideImage = 1,

        /// <summary>
        /// Post-process file as a video into Azure Media Services
        /// </summary>
        Video = 2,
    }
}