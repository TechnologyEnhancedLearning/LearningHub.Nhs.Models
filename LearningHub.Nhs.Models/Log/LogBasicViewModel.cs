namespace LearningHub.Nhs.Models.Log
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The log basic view model.
    /// </summary>
    public class LogBasicViewModel
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
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
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
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }
    }
}
