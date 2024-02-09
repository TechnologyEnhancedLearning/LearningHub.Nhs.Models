namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The create assessment resource activity view model.
    /// </summary>
    public class CreateAssessmentResourceActivityViewModel
    {
        /// <summary>
        /// Gets or sets the resource activity id.
        /// </summary>
        public int ResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the extra attempt reason.
        /// </summary>
        public string ExtraAttemptReason { get; set; }

        /// <summary>
        /// Gets or sets the state of the match questions.
        /// </summary>
        public ICollection<AssessmentResourceActivityMatchQuestionViewModel> MatchQuestions { get; set; }
    }
}
