﻿// <copyright file="Roadmap.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The roadmap.
    /// </summary>
    public class Roadmap : EntityBase
    {
        /// <summary>
        /// Gets or sets the roadmap type id.
        /// </summary>
        public int RoadmapTypeId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the roadmap date.
        /// </summary>
        public DateTimeOffset? RoadmapDate { get; set; }

        /// <summary>
        /// Gets or sets the image name.
        /// </summary>
        public string ImageName { get; set; }

        /// <summary>
        /// Gets or sets the order number.
        /// </summary>
        public int OrderNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the roadmap is published.
        /// </summary>
        public bool Published { get; set; }

        /// <summary>
        /// Gets or sets the roadmap type.
        /// </summary>
        public virtual RoadmapType RoadmapType { get; set; }
    }
}
