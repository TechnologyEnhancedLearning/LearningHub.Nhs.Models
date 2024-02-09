namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The Event log enum.
    /// </summary>
    public enum EventLogEnum
    {
        /// <summary>
        /// The content structure admin log.
        /// </summary>
        ContentStructureAdmin = 1,
    }

    /// <summary>
    /// The Event log event type enum.
    /// </summary>
    public enum EventLogEventTypeEnum
    {
        /// <summary>
        /// The critical.
        /// </summary>
        Critical = 1,

        /// <summary>
        /// The error.
        /// </summary>
        Error = 2,

        /// <summary>
        /// The information.
        /// </summary>
        Information = 3,

        /// <summary>
        /// The warning.
        /// </summary>
        Warning = 4,
    }
}
