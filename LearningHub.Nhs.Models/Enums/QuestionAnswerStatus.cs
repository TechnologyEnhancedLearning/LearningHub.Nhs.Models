namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The status of a question answer.
    /// </summary>
    public enum QuestionAnswerStatus
    {
        /// <summary>
        /// An incorrect answer.
        /// </summary>
        Incorrect = 0,

        /// <summary>
        /// A reasonable answer.
        /// </summary>
        Reasonable = 1,

        /// <summary>
        /// A best answer. Only one answer may be best in a given question.
        /// </summary>
        Best = 2,
    }
}