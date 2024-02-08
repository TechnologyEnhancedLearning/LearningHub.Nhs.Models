namespace LearningHub.Nhs.Models.Entities.Resource.Blocks
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// A question block.
    /// </summary>
    public class QuestionBlock : EntityBase
    {
        /// <summary>
        /// Gets or sets the Block Id.
        /// </summary>
        public int BlockId { get; set; }

        /// <summary>
        /// Gets or sets the Block.
        /// </summary>
        public virtual Block Block { get; set; }

        /// <summary>
        /// Gets or sets the id of the block collection containing the question. Should not contain any question blocks.
        /// </summary>
        public int QuestionBlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the block collection containing the question. Should not contain any question blocks.
        /// </summary>
        public virtual BlockCollection QuestionBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the id of the block collection containing feedback to the question. Should not contain any question blocks.
        /// </summary>
        public int FeedbackBlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the block collection containing feedback to the question. Should not contain any question blocks.
        /// </summary>
        public virtual BlockCollection FeedbackBlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the question type.
        /// </summary>
        public QuestionTypeEnum QuestionType { get; set; }

        /// <summary>
        /// Gets or sets the list of answers for the question. Must have length between 2 and 5 inclusive.
        /// </summary>
        public virtual ICollection<QuestionAnswer> Answers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether users can reveal the best answer before answering themselves.
        /// </summary>
        public bool? AllowReveal { get; set; }
    }
}