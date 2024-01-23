// <copyright file="InternalSystemViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Maintenance
{
    using System;

    /// <summary>
    /// The Internal system viemodel.
    /// </summary>
    public class InternalSystemViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

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

        /// <summary>
        /// Gets or sets a value indicating whether deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the amend date.
        /// </summary>
        public DateTimeOffset AmendDate { get; set; }
    }
}
