namespace LearningHub.Nhs.Models.Log
{
    /// <summary>
    /// The log view model.
    /// </summary>
    public class LogViewModel : LogBasicViewModel
    {
        /// <summary>
        /// Gets or sets the logger.
        /// </summary>
        public string Logger { get; set; }

        /// <summary>
        /// Gets or sets the callsite.
        /// </summary>
        public string Callsite { get; set; }

        /// <summary>
        /// Gets or sets the exception.
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }
    }
}
