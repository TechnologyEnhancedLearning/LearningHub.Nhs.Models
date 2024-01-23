// <copyright file="AssessmentResourceVersion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The assessment resource version.
    /// </summary>
    public class AssessmentResourceVersion : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the assessment type (formal vs. informal).
        /// </summary>
        public AssessmentTypeEnum AssessmentType { get; set; }

        /// <summary>
        /// Gets or sets the assessment content ID.
        /// </summary>
        public int? AssessmentContentId { get; set; }

        /// <summary>
        /// Gets or sets the assessment content.
        /// </summary>
        public virtual BlockCollection AssessmentContent { get; set; }

        /// <summary>
        /// Gets or sets the maximum attempts. If null, there is no attempt limit.
        /// </summary>
        public int? MaximumAttempts { get; set; }

        /// <summary>
        /// Gets or sets the pass mark as a percentage, if it exists.
        /// </summary>
        public int? PassMark { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether assessment questions must be answered in order.
        /// </summary>
        public bool AnswerInOrder { get; set; }

        /// <summary>
        /// Gets or sets the end guidance ID.
        /// </summary>
        public int? EndGuidanceId { get; set; }

        /// <summary>
        /// Gets or sets the end guidance.
        /// </summary>
        public virtual BlockCollection EndGuidance { get; set; }
    }
}