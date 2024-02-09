namespace LearningHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The log.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the application.
        /// </summary>
        public string Application { get; set; }

        /// <summary>
        /// Gets or sets the logged.
        /// </summary>
        public DateTime Logged { get; set; }

        /// <summary>
        /// Gets or sets the level.
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

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
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        public string UserName { get; set; }
    }
}
