namespace LearningHub.Nhs.Models.Resource.AzureMediaAsset
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The MediaAssetOutputViewModel.
    /// </summary>
    public class MediaAssetOutputViewModel
    {
        /// <summary>
        /// Gets or sets the resource versionId.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource versionId.
        /// </summary>
        public int VideoResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the audio resource versionId.
        /// </summary>
        public int AudioResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource type enumeration.
        /// </summary>
        public ResourceTypeEnum ResourceTypeEnum { get; set; }

        /// <summary>
        /// Gets or sets the FilePath.
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the duration in milliseconds.
        /// </summary>
        public int DurationInMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the LocatorUri.
        /// </summary>
        public string LocatorUri { get; set; }

        /// <summary>
        /// Gets or sets the Encode Job Name.
        /// </summary>
        public string EncodeJobName { get; set; }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int UserId { get; set; }
    }
}
