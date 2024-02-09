namespace LearningHub.Nhs.Models.Resource.Activity
{
    using System.Collections.Generic;

    /// <summary>
    /// The create assessment resource activity interaction view model.
    /// </summary>
    public class CreateAssessmentResourceActivityInteractionViewModel
    {
        /// <summary>
        /// Gets or sets the assessment resource activity id.
        /// </summary>
        public int AssessmentResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets the question block id.
        /// </summary>
        public int QuestionNumber { get; set; }

        /// <summary>
        /// Gets or sets the selected answers.
        /// </summary>
        public ICollection<int> Answers { get; set; }
    }
}
