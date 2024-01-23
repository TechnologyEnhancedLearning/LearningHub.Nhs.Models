// <copyright file="CacheReadResponse.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Caching
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The cache read response class.
    /// </summary>
    /// <typeparam name="T">Input type.</typeparam>
    public class CacheReadResponse<T>
    {
        /// <summary>
        /// Gets or sets the cache response enum.
        /// </summary>
        public CacheReadResponseEnum ResponseEnum { get; set; }

        /// <summary>
        /// Gets or sets item.
        /// </summary>
        public T Item { get; set; }

        /// <summary>
        /// Gets or sets exception.
        /// </summary>
        public Exception Exception { get; set; }
    }
}
