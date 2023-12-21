// <copyright file="DetectJsLog.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities
{
    /// <summary>
    /// The DetectJsLog.
    /// </summary>
    public class DetectJsLog : EntityBase
    {
        /// <summary>
        /// Gets or sets the JsEnabledRequest.
        /// </summary>
        public long JsEnabledRequest { get; set; }

        /// <summary>
        /// Gets or sets the JsDisabledRequest.
        /// </summary>
        public long JsDisabledRequest { get; set; }
    }
}