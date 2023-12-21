// <copyright file="ResourceVersionValidationResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using System.Collections.Generic;

    /// <summary>
    /// The resource version validation result.
    /// </summary>
    public partial class ResourceVersionValidationResult : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionValidationResult"/> class.
        /// </summary>
        public ResourceVersionValidationResult()
        {
            this.ResourceVersionValidationRuleResults = new HashSet<ResourceVersionValidationRuleResult>();
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource version validation rule results.
        /// </summary>
        public virtual ICollection<ResourceVersionValidationRuleResult> ResourceVersionValidationRuleResults { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the validation result was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }
    }
}
