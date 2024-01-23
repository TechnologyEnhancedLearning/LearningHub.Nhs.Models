// <copyright file="ResourceAzureMediaAssetViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// ResourceAzureMediaAssetViewModel.
    /// </summary>
    public class ResourceAzureMediaAssetViewModel
    {
        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets locatoruri.
        /// </summary>
        public string LocatorUri { get; set; }

        /// <summary>
        /// Gets or sets the encode job name.
        /// </summary>
        public string EncodeJobName { get; set; }

        /// <summary>
        /// Gets or sets the video resource version id.
        /// </summary>
        public int VideoResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the audio resource version id.
        /// </summary>
        public int AudioResourceVersionId { get; set; }

        /// <summary>
        ///  Gets or sets the AES authenticationtoken.
        /// </summary>
        public string AuthenticationToken { get; set; }
    }
}
