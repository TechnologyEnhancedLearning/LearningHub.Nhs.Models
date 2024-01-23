﻿// <copyright file="ResourceFileModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Migration.InputModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// Data model class for representing a resource file, used by the StandardInputModel class.
    /// </summary>
    public class ResourceFileModel
    {
        /// <summary>
        /// Gets or sets the ResourceIndex.
        /// </summary>
        [JsonProperty(PropertyName = "Resource Index")]
        public int? ResourceIndex { get; set; }

        /// <summary>
        /// Gets or sets the ResourceUrl.
        /// </summary>
        [JsonProperty(PropertyName = "Resource URL")]
        public string ResourceUrl { get; set; }
    }
}
