namespace LearningHub.Nhs.Models.Resource
{
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Resource.Blocks;

    /// <summary>
    /// The view model for a question answer.
    /// </summary>
    public class QuestionAnswerViewModel
    {
        /// <summary>
        /// Gets or sets the order of this question answer (derives the answer number).
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the status of the answer. Only one answer on a question may have status "Best".
        /// </summary>
        public QuestionAnswerStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the block collection for this answer. The block collection must be checked to ensure it has a single block, and that block is not a question block.
        /// </summary>
        public BlockCollectionViewModel BlockCollection { get; set; }

        /// <summary>
        /// Gets or sets the image annotation order for this answer (used in image zone questions).
        /// </summary>
        public int? ImageAnnotationOrder { get; set; }
    }
}