// <copyright file="AssessmentResourceActivityMatchQuestion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Activity
{
    using LearningHub.Nhs.Models.Entities.Resource;

    /// <summary>
    /// The AssessmentResourceActivityMatchQuestion.
    /// </summary>
    public partial class AssessmentResourceActivityMatchQuestion : EntityBase
    {
        /// <summary>
        /// Gets or sets the AssessmentResourceActivityId.
        /// </summary>
        public int AssessmentResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the AssessmentResourceActivity.
        /// </summary>
        public virtual AssessmentResourceActivity AssessmentResourceActivity { get; set; }

        /// <summary>
        /// Gets or sets the QuestionNumber.
        /// </summary>
        public int QuestionNumber { get; set; }

        /// <summary>
        /// Gets or sets the FirstMatchAnswerId.
        /// </summary>
        public int FirstMatchAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the FirstMatchAnswer.
        /// </summary>
        public virtual QuestionAnswer FirstMatchAnswer { get; set; }

        /// <summary>
        /// Gets or sets the SecondMatchAnswerId.
        /// </summary>
        public int SecondMatchAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the SecondMatchAnswer.
        /// </summary>
        public virtual QuestionAnswer SecondMatchAnswer { get; set; }

        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        public int Order { get; set; }
    }
}
