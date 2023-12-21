// <copyright file="ResourceVersionProvider.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The ResourceVersionProvider.
    /// </summary>
    public class ResourceVersionProvider : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the provider id.
        /// </summary>
        public int? ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        public virtual Provider Provider { get; set; }
    }
}
