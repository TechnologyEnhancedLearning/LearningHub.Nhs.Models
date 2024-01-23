// <copyright file="ResourceTypeValidationRuleEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The validation rule enum.
    /// Corresponds to entry in resources.ResourceTypeValidationRule.
    /// </summary>
    public enum ResourceTypeValidationRuleEnum
    {
        /// <summary>
        /// LMS Manifest present.
        /// </summary>
        Scorm_ManifestPresent = 1,

        /// <summary>
        /// Quicklink Id is valid
        /// </summary>
        Scorm_QuickLinkIdValid = 2,

        /// <summary>
        /// Catalog Entry is valid
        /// </summary>
        Scorm_CatalogEntryValid = 3,

        /// <summary>
        /// Schema Version is valid
        /// </summary>
        Scorm_SchemaVersionValid = 4,

        /// <summary>
        /// Manifest fluent validation is valid
        /// </summary>
        Scorm_ManifestFluentValidatorValid = 5,
    }
}
