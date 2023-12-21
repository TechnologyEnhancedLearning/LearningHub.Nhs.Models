// <copyright file="AssessmentValidator.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Validation
{
    using System.Linq;
    using FluentValidation;
    using LearningHub.Nhs.Models.Enums;
    using LearningHub.Nhs.Models.Resource;
    using LearningHub.Nhs.Models.Resource.Blocks;

    /// <summary>
    /// The assessment validator.
    /// </summary>
    public class AssessmentValidator : AbstractValidator<AssessmentViewModel>
    {
        private int maxTextBlockLength = 3000;

        /// <summary>
        /// Initializes a new instance of the <see cref="AssessmentValidator"/> class.
        /// </summary>
        public AssessmentValidator()
        {
            this.RuleFor(x => x.PassMark)
                .Must((assessment, passMark, context) =>
                    passMark == null || (passMark >= 0 && passMark <= 100))
                .WithMessage("Pass mark must be between 0% and 100%");

            this.RuleFor(x => x.AssessmentContent)
                .Must((assessment, content, context) =>
                    content.Blocks.Any(block => block.BlockType == BlockType.Question))
                .WithMessage("Assessments must contain at least one question");

            this.RuleFor(x => x.AssessmentContent)
                .Must((assessment, content, context) => content.Blocks
                    .Where(block => block.BlockType == BlockType.Text)
                    .All(block => block.TextBlock.Content.Length <= this.maxTextBlockLength))
                .WithMessage($"Text blocks in content should not exceed {this.maxTextBlockLength} characters in length");

            this.RuleFor(x => x.AssessmentType)
                .Must((assessment, type, context) => type != AssessmentTypeEnum.Undefined)
                .WithMessage("Assessment type must be formal or informal, not undefined");

            this.RuleFor(x => x.EndGuidance)
                .Must((assessment, guidance, context) => guidance.Blocks.All(
                    block => block.BlockType != BlockType.Question && block.BlockType != BlockType.PageBreak))
                .WithMessage("Assessment guidance cannot contain questions or page breaks");

            this.RuleFor(x => x.EndGuidance)
                .Must((assessment, guidance, context) => guidance.Blocks
                    .Where(block => block.BlockType == BlockType.Text)
                    .All(block => block.TextBlock.Content.Length <= this.maxTextBlockLength))
                .WithMessage($"Text blocks in guidance should not exceed {this.maxTextBlockLength} characters in length");

            this.RuleFor(x => x.MaximumAttempts)
                .Must((assessment, maxAttempts, context) =>
                    assessment.AssessmentType != AssessmentTypeEnum.Informal || maxAttempts == null)
                .WithMessage("Informal assessments take an unlimited number of attempts");

            this.RuleFor(x => x.MaximumAttempts)
                .Must((assessment, maxAttempts, context) =>
                    assessment.AssessmentType != AssessmentTypeEnum.Formal
                    || maxAttempts == null
                    || (maxAttempts >= 1 && maxAttempts <= 10))
                .WithMessage("Formal assessments take between 1 and 10 or an unlimited number of attempts");
        }
    }
}