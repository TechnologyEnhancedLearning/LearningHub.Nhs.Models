// <copyright file="QuestionTypeEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The types of question can be given in a teaching case.
    /// </summary>
    public enum QuestionTypeEnum
    {
        /// <summary>
        /// A question where the user can select a single answer.
        /// </summary>
        SingleChoice = 1,

        /// <summary>
        /// A question where the user can select multiple answers.
        /// </summary>
        MultipleChoice = 2,

        /// <summary>
        /// A question where the user can select a correct annotation from a whole slide image with multiple annotations.
        /// </summary>
        ImageZone = 3,

        /// <summary>
        /// A question where the user is asked to match pairs of values.
        /// </summary>
        MatchGame = 4,
    }
}
