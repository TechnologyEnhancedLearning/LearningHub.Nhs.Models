namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Resource.Activity;

    /// <summary>
    /// The view model for receiving the assessment progress.
    /// </summary>
    public class AssessmentProgressViewModel
    {
        /// <summary>
        /// Gets or sets the assessment view model.
        /// </summary>
        public AssessmentViewModel AssessmentViewModel { get; set; }

        /// <summary>
        /// Gets or sets the answers, a 2D list of the orders of the selected answers.
        /// </summary>
        public List<List<int>> Answers { get; set; }

        /// <summary>
        /// Gets or sets the id of the linked assessment resource activity.
        /// </summary>
        public int AssessmentResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the user's score (not a percentage).
        /// </summary>
        public int? UserScore { get; set; }

        /// <summary>
        /// Gets or sets the maximum possible score (not a percentage).
        /// </summary>
        public int MaxScore { get; set; }

        /// <summary>
        /// Gets or sets the number of attempts that the user has made on this assessment.
        /// </summary>
        public int NumberOfAttempts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user has passed this assessment.
        /// </summary>
        public bool Passed { get; set; }

        /// <summary>
        /// Gets or sets the state of the match questions.
        /// </summary>
        public ICollection<AssessmentResourceActivityMatchQuestionViewModel> MatchQuestions { get; set; }
    }
}
