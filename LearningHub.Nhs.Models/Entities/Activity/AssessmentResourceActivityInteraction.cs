// <copyright file="AssessmentResourceActivityInteraction.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;

    /// <summary>
    /// The AssessmentResourceActivityInteraction.
    /// </summary>
    public partial class AssessmentResourceActivityInteraction : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentResourceActivityInteraction"/> class.
        /// </summary>
        public AssessmentResourceActivityInteraction()
        {
            this.Answers = new HashSet<AssessmentResourceActivityInteractionAnswer>();
        }

        /// <summary>
        /// Gets or sets the Assessment Resource ActivityId.
        /// </summary>
        public int AssessmentResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the assessment resource activity.
        /// </summary>
        public virtual AssessmentResourceActivity AssessmentResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the QuestionBlockId.
        /// </summary>
        public int QuestionBlockId { get; set; }

        /// <summary>
        /// Gets or sets the QuestionBlock.
        /// </summary>
        public virtual QuestionBlock QuestionBlock { get; set; }

        /// <summary>
        /// Gets or sets the selected answers for this interaction.
        /// </summary>
        public virtual ICollection<AssessmentResourceActivityInteractionAnswer> Answers { get; set; }
    }
}