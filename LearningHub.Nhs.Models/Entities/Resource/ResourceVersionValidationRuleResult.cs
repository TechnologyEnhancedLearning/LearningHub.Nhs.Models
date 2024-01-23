// <copyright file="ResourceVersionValidationRuleResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource version validation rule result.
    /// </summary>
    public partial class ResourceVersionValidationRuleResult : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version validation Result id.
        /// </summary>
        public int ResourceVersionValidationResultId { get; set; }

        /// <summary>
        /// Gets or sets the resource type validation rule enumeration.
        /// </summary>
        public ResourceTypeValidationRuleEnum ResourceTypeValidationRuleEnum { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the validation was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the resource version validation result.
        /// </summary>
        public virtual ResourceVersionValidationResult ResourceVersionValidationResult { get; set; }
    }
}
