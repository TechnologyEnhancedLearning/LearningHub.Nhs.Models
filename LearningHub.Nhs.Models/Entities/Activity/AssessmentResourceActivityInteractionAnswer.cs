// <copyright file="AssessmentResourceActivityInteractionAnswer.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The AssessmentResourceActivityInteraction.
    /// </summary>
    public partial class AssessmentResourceActivityInteractionAnswer : EntityBase
    {
        /// <summary>
        /// Gets or sets the AssessmentResourceActivityInteractionId.
        /// </summary>
        public int AssessmentResourceActivityInteractionId { get; set; }

        /// <summary>
        /// Gets or sets the AssessmentResourceActivityInteraction.
        /// </summary>
        public virtual AssessmentResourceActivityInteraction AssessmentResourceActivityInteraction { get; set; }

        /// <summary>
        /// Gets or sets the QuestionAnswerId.
        /// </summary>
        public int QuestionAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the QuestionAnswer.
        /// </summary>
        public virtual QuestionAnswer QuestionAnswer { get; set; }

        /// <summary>
        /// Gets or sets the MatchedQuestionAnswerId.
        /// </summary>
        public int? MatchedQuestionAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the MatchedQuestionAnswer.
        /// </summary>
        public virtual QuestionAnswer MatchedQuestionAnswer { get; set; }
    }
}
