namespace LearningHub.Nhs.Caching
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The cache write response class.
    /// </summary>
    public class CacheWriteResponse
    {
        /// <summary>
        /// Gets or sets the cache response enum.
        /// </summary>
        public CacheWriteResponseEnum ResponseEnum { get; set; }

        /// <summary>
        /// Gets or sets exception.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
