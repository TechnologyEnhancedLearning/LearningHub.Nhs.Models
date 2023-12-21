// <copyright file="ResourceVersionValidationRuleResultViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource
{
    using System;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource version validation rule result view model.
    /// </summary>
    public class ResourceVersionValidationRuleResultViewModel
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
        /// Gets or sets the CreateDate.
        /// </summary>
        public DateTimeOffset CreateDate { get; set; }
    }
}
