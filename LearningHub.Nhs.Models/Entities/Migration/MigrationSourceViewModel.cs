// <copyright file="MigrationSourceViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Migration
{
    /// <summary>
    /// The migration source.
    /// </summary>
    public partial class MigrationSourceViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the HostName.
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the ResourcePath.
        /// </summary>
        public string ResourcePath { get; set; }

        /// <summary>
        /// Gets or sets the ResourceIdentifierPosition.
        /// </summary>
        public int ResourceIdentifierPosition { get; set; }

        /// <summary>
        /// Gets or sets the ResourceRegEx.
        /// </summary>
        public string ResourceRegEx { get; set; }
    }
}
