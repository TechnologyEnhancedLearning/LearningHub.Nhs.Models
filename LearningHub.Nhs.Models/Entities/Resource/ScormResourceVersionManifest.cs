﻿// <copyright file="ScormResourceVersionManifest.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The scorm resource version manifest.
    /// </summary>
    public partial class ScormResourceVersionManifest : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScormResourceVersionManifest"/> class.
        /// </summary>
        public ScormResourceVersionManifest()
        {
        }

        /// <summary>
        /// Gets or sets the scorm resource version id.
        /// </summary>
        public int ScormResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the author.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        public string Keywords { get; set; }

        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        public string Duration { get; set; }

        /// <summary>
        /// Gets or sets the manifest url.
        /// </summary>
        public string ManifestUrl { get; set; }

        /// <summary>
        /// Gets or sets the quick link id.
        /// </summary>
        public string QuicklinkId { get; set; }

        /// <summary>
        /// Gets or sets the catalog entry.
        /// </summary>
        public string CatalogEntry { get; set; }

        /// <summary>
        /// Gets or sets the mastery score.
        /// </summary>
        public decimal? MasteryScore { get; set; }

        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier.
        /// </summary>
        public string ResourceIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the item identifier.
        /// </summary>
        public string ItemIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the template version.
        /// </summary>
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Gets or sets the launch data.
        /// </summary>
        public string LaunchData { get; set; }

        /// <summary>
        /// Gets or sets the max time allowed.
        /// Format "HHHH:MM:SS.SS".
        /// </summary>
        public string MaxTimeAllowed { get; set; }

        /// <summary>
        /// Gets or sets the time limit action.
        /// </summary>
        public string TimeLimitAction { get; set; }

        /// <summary>
        /// Gets or sets the scorm resource version.
        /// </summary>
        public virtual ScormResourceVersion ScormResourceVersion { get; set; }
    }
}
