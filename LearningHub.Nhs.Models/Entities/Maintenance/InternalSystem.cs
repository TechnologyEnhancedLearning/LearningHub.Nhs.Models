// <copyright file="InternalSystem.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Maintenance
{
    /// <summary>
    /// The Internal System.
    /// </summary>
    public class InternalSystem : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether offline.
        /// </summary>
        public bool IsOffline { get; set; }
    }
}
