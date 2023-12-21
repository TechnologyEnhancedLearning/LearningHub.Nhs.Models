// <copyright file="ExternalSystemDeepLink.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.External
{
    /// <summary>
    /// The external system deeplink entity.
    /// </summary>
    public class ExternalSystemDeepLink : EntityBase
    {
        /// <summary>
        /// Gets or sets the external system name.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string DeepLink { get; set; }
    }
}