// <copyright file="CatalogueNodeVersionProvider.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System;

    /// <summary>
    /// The CatalogueNodeVersionKeyword.
    /// </summary>
    public class CatalogueNodeVersionProvider : EntityBase
    {
        /// <summary>
        /// Gets or sets the catalogue node version id.
        /// </summary>
        public int CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the provider id.
        /// </summary>
        public int ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the removal date of a provider.
        /// </summary>
        public DateTimeOffset? RemovalDate { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        public virtual Provider Provider { get; set; }
    }
}
