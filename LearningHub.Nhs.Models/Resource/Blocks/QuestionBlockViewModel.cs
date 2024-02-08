namespace LearningHub.Nhs.Models.Resource.Blocks
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="QuestionBlockViewModel" />.
    /// </summary>
    public class QuestionBlockViewModel
    {
        /// <summary>
        /// Gets or sets the block collection containing the question. Should not contain any question blocks.
        /// </summary>
        public BlockCollectionViewModel QuestionBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the block collection containing feedback to the question. Should not contain any question blocks.
        /// </summary>
        public BlockCollectionViewModel FeedbackBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the question type.
        /// </summary>
        public QuestionTypeEnum QuestionType { get; set; }

        /// <summary>
        /// Gets or sets the list of answers for the question. Must have length between 2 and 5 inclusive.
        /// </summary>
        public List<QuestionAnswerViewModel> Answers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users can reveal the best answer before answering themselves.
        /// </summary>
        public bool? AllowReveal { get; set; }
    }
}