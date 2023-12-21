// <copyright file="CaseResourceVersion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;

    /// <summary>
    /// The case resource version.
    /// </summary>
    public class CaseResourceVersion : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the Block Collection Id.
        /// </summary>
        public int? BlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the Block Collection.
        /// </summary>
        public virtual BlockCollection BlockCollection { get; set; }
    }
}
