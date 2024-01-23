// <copyright file="QuestionAnswer.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities.Resource.Blocks;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// An answer to a question.
    /// </summary>
    public class QuestionAnswer : EntityBase
    {
        /// <summary>
        /// Gets or sets the question ID to which the answer belongs.
        /// </summary>
        public int QuestionBlockId { get; set; }

        /// <summary>
        /// Gets or sets the question to which the answer belongs.
        /// </summary>
        public virtual QuestionBlock QuestionBlock { get; set; }

        /// <summary>
        /// Gets or sets the order of this question answer (derives the answer number).
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the status of the answer. Only one answer on a question may have status "Best".
        /// </summary>
        public QuestionAnswerStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the block collection ID for this answer. The block collection must be checked to ensure it has a single block, and that block is not a question block.
        /// </summary>
        public int? BlockCollectionId { get; set; }

        /// <summary>
        /// Gets or sets the block collection for this answer. The block collection must be checked to ensure it has a single block, and that block is not a question block.
        /// </summary>
        public virtual BlockCollection BlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the image annotation ID for this answer.
        /// </summary>
        public int? ImageAnnotationId { get; set; }

        /// <summary>
        /// Gets or sets the image annotation for this answer.
        /// </summary>
        public virtual ImageAnnotation ImageAnnotation { get; set; }

        /// <summary>
        /// Gets or sets the image annotation order for this answer.
        /// </summary>
        public int? ImageAnnotationOrder { get; set; }
    }
}