namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Resource.Blocks;

    /// <summary>
    /// The assessment view model.
    /// </summary>
    public class AssessmentViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the assessment type (formal vs. informal).
        /// </summary>
        public AssessmentTypeEnum AssessmentType { get; set; }

        /// <summary>
        /// Gets or sets the assessment content.
        /// </summary>
        public virtual BlockCollectionViewModel AssessmentContent { get; set; }

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
        /// Gets or sets the end guidance.
        /// </summary>
        public virtual BlockCollectionViewModel EndGuidance { get; set; }
    }
}