// <copyright file="PublicationLog.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The publication log.
    /// </summary>
    public class PublicationLog : EntityBase
    {
        /// <summary>
        /// Gets or sets the publication id.
        /// </summary>
        public int PublicationId { get; set; }

        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int? NodeId { get; set; }

        /// <summary>
        /// Gets or sets the publication.
        /// </summary>
        public virtual Publication Publication { get; set; }

        /// <summary>
        /// Gets or sets the node.
        /// </summary>
        public virtual Node Node { get; set; }
    }
}
