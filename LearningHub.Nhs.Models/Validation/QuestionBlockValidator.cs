// <copyright file="QuestionBlockValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Collections.Generic;
    using System.Linq;
    using FluentValidation;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Resource;
    using LearningHub.Nhs.Models.Resource.Blocks;
    using LearningHub.Nhs.Models.Resource.Blocks.Annotations;

    /// <summary>
    /// The question validator.
    /// </summary>
    public class QuestionBlockValidator : AbstractValidator<QuestionBlockViewModel>
    {
        /// <summary>
        /// The minimum number of possible answers that a question can have to be considered valid.
        /// </summary>
        public const int MinimumAnswers = 2;

        /// <summary>
        /// The maximum number of possible answers that a question can have to be considered valid.
        /// </summary>
        public const int MaximumAnswers = 20;

        /// <summary>
        /// The maximum number of possible answers that a match game and an image zone question can have to be considered valid.
        /// </summary>
        public const int MaximumAnswersForMatchGameAndImageZone = 10;

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionBlockValidator"/> class.
        /// </summary>
        /// <param name="maximumQuestionTextLength">
        /// The maximum size of the question text.
        /// </param>
        /// <param name="maximumAnswerTextLength">
        /// The maximum size of the answer text.
        /// </param>
        /// <param name="maximumFeedbackTextLength">
        /// The maximum size of the feedback text.
        /// </param>
        public QuestionBlockValidator(
            int maximumQuestionTextLength = 250,
            int maximumAnswerTextLength = 120,
            int maximumFeedbackTextLength = 3000)
        {
            this.RuleFor(x => x.QuestionBlockCollection)
                .Must((question, blockCollection, context) =>
                    blockCollection.Blocks.TrueForAll(this.IsAllowedContentBlock) && blockCollection.Blocks.Count > 0)
                .WithMessage("Question content cannot be empty and may not contain any inner questions");

            this.RuleFor(x => x.QuestionBlockCollection)
                .Must((question, blockCollection, context) =>
                    blockCollection.Blocks
                        .Where(block => block.BlockType == BlockType.Text)
                        .All(block => block.TextBlock.Content.Length <= maximumQuestionTextLength))
                .WithMessage($"Question text must not exceed {maximumQuestionTextLength} characters in length");

            this.RuleFor(x => x.FeedbackBlockCollection)
                .Must((question, blockCollection, context) =>
                    blockCollection.Blocks.TrueForAll(this.IsAllowedContentBlock) && blockCollection.Blocks.Count > 0)
                .WithMessage("Question feedback cannot be empty and may not contain any inner questions");

            this.RuleFor(x => x.FeedbackBlockCollection)
                .Must((question, blockCollection, context) =>
                    blockCollection.Blocks
                        .Where(block => block.BlockType == BlockType.Text)
                        .All(block => block.TextBlock.Content.Length <= maximumFeedbackTextLength))
                .WithMessage($"Feedback text must not exceed {maximumFeedbackTextLength} characters in length");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) => answers.Count is >= MinimumAnswers and <= MaximumAnswers)
                .Unless(question => question.QuestionType is QuestionTypeEnum.MatchGame or QuestionTypeEnum.ImageZone)
                .WithMessage($"There must be between {MinimumAnswers} and {MaximumAnswers} answers to a question");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) => answers.Count is >= MinimumAnswers and <= MaximumAnswersForMatchGameAndImageZone)
                .When(question => question.QuestionType is QuestionTypeEnum.MatchGame or QuestionTypeEnum.ImageZone)
                .WithMessage(
                    $"There must be between {MinimumAnswers} and {MaximumAnswersForMatchGameAndImageZone} answers to a question");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) =>
                    answers
                        .Select(a => a.Order)
                        .OrderBy(x => x)
                        .SequenceEqual(Enumerable.Range(0, answers.Count)))
                .WithMessage("Answer order numbers must be unique in [0, 1, ..., n-1], where n is the number of answers.");

            this.When(question => question.QuestionType == QuestionTypeEnum.SingleChoice, () =>
            {
                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) => this.HasExactlyOneBestAnswer(answers))
                    .WithMessage("There must be exactly one Best answer for single choice questions");
            });

            this.When(question => question.QuestionType == QuestionTypeEnum.MultipleChoice, () =>
            {
                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) => answers.Count(a => a.Status == QuestionAnswerStatus.Best) == 0)
                    .WithMessage("There must be no Best answers for multiple choice questions");
            });

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) => answers.All(a => a.Status == QuestionAnswerStatus.Best))
                .When(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                .WithMessage("There must be no Reasonable or Incorrect Answers for match game");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) => answers.All(a => a.BlockCollection.Blocks.Count == 2))
                .When(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                .WithMessage("Every answer should have 2 blocks for match game");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) => answers.All(a => a.Status == QuestionAnswerStatus.Best))
                .When(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                .WithMessage("There must be only best answers for match game");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) =>
                    answers.All(a => a.BlockCollection.Blocks.All(b =>
                        b.BlockType == BlockType.Text ||
                        (b.BlockType == BlockType.Media && b.MediaBlock.MediaType == MediaType.Image))))
                .When(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                .WithMessage("Match game answers must be either text or image blocks");

            this.RuleFor(x => x.Answers)
                .Must((question, answers, context) =>
                {
                    var firstBlockType = answers[0].BlockCollection.Blocks[0].BlockType;
                    var secondBlockType = answers[0].BlockCollection.Blocks[1].BlockType;
                    return answers.All(a =>
                        a.BlockCollection.Blocks[0].BlockType == firstBlockType &&
                        a.BlockCollection.Blocks[1].BlockType == secondBlockType);
                }).When(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                .WithMessage("All the match pairs should have the same block types");

            this.When(question => question.QuestionType == QuestionTypeEnum.ImageZone, () =>
            {
                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) => answers.TrueForAll(a => a.BlockCollection == null))
                    .WithMessage("Answers must have null blockCollections for image zone questions");

                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) =>
                        this.HasAtLeastOneBestAnswer(answers)
                        && answers.Select(a => a.ImageAnnotationOrder).Distinct().Count() == answers.Count)
                    .WithMessage("There must be at least one best answer, and each answer imageAnnotationOrder must be unique for image zone questions");

                this.RuleFor(x => x.QuestionBlockCollection)
                    .Must((question, blockCollection, context) =>
                        this.HasImageZoneContentBlocks(blockCollection.Blocks)
                        && this.AnnotationOrdersMatch(question, blockCollection.Blocks[1]))
                    .WithMessage("There must be exactly one text block followed by exactly one whole slide image or media block, and all question image annotation orders must match the answer imageAnnotationOrders for image zone questions");
            }).Otherwise(() =>
            {
                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) =>
                        this.AnswersAllSingleBlocksOfSameType(answers)
                        && this.IsAllowedContentBlock(answers[0].BlockCollection.Blocks[0]))
                    .Unless(question => question.QuestionType == QuestionTypeEnum.MatchGame)
                    .WithMessage("Answers must be of the same type and may not be questions");

                this.RuleFor(x => x.Answers)
                    .Must((question, answers, context) =>
                        answers.All(answer =>
                        {
                            var block = answer.BlockCollection.Blocks[0];
                            return block.TextBlock == null || block.TextBlock.Content.Length <= maximumAnswerTextLength;
                        }))
                    .WithMessage($"Text answers must not exceed {maximumAnswerTextLength} characters in length.");
            });
        }

        private bool IsAllowedContentBlock(BlockViewModel block)
        {
            return block.BlockType == BlockType.Text || block.BlockType == BlockType.Media || block.BlockType == BlockType.WholeSlideImage;
        }

        private bool AnswersAllSingleBlocksOfSameType(List<QuestionAnswerViewModel> answers)
        {
            return answers.TrueForAll(a => a.BlockCollection.Blocks.Count == 1 && a.BlockCollection.Blocks[0].BlockType == answers[0].BlockCollection.Blocks[0].BlockType);
        }

        private bool HasAtLeastOneBestAnswer(List<QuestionAnswerViewModel> answers)
        {
            return answers.Count(a => a.Status == QuestionAnswerStatus.Best) >= 1;
        }

        private bool HasExactlyOneBestAnswer(List<QuestionAnswerViewModel> answers)
        {
            return answers.Count(a => a.Status == QuestionAnswerStatus.Best) == 1;
        }

        private bool HasImageZoneContentBlocks(List<BlockViewModel> blocks)
        {
            return blocks.Count == 2 && blocks[0].BlockType == BlockType.Text && blocks[1].BlockType == BlockType.WholeSlideImage;
        }

        private bool AnnotationOrdersMatch(QuestionBlockViewModel question, BlockViewModel block)
        {
            List<ImageAnnotationViewModel> annotations = block.WholeSlideImageBlock?.WholeSlideImageBlockItems[0].WholeSlideImage.Annotations;
            List<int> questionOrders = annotations.Select(a => a.Order).ToList();
            List<int> answerOrders = question.Answers.Select(a => a.ImageAnnotationOrder.GetValueOrDefault(-1)).ToList();
            return questionOrders.SequenceEqual(answerOrders);
        }
    }
}
