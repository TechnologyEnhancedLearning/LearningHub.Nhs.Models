// <copyright file="AssessmentResourceActivityMatchQuestionViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Activity
{
    /// <summary>
    /// The AssessmentResourceActivityMatchQuestionViewModel.
    /// </summary>
    public class AssessmentResourceActivityMatchQuestionViewModel
    {
        /// <summary>
        /// Gets or sets the question number.
        /// </summary>
        public int QuestionNumber { get; set; }

        /// <summary>
        /// Gets or sets the order of the answers.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the first answer id.
        /// </summary>
        public int FirstMatchAnswerId { get; set; }

        /// <summary>
        /// Gets or sets the second answer id.
        /// </summary>
        public int SecondMatchAnswerId { get; set; }
    }
}
