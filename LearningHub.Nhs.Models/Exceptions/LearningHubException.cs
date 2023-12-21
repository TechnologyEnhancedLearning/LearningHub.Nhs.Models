// <copyright file="LearningHubException.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Exceptions
{
    using System;

    /// <summary>
    /// The learning hub exception.
    /// </summary>
    public class LearningHubException : Exception
    {
        /// <summary>
        /// The code.
        /// </summary>
        private int code;

        /// <summary>
        /// The description.
        /// </summary>
        private string description;

        /// <summary>
        /// Initializes a new instance of the <see cref="LearningHubException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="code">
        /// The code.
        /// </param>
        public LearningHubException(string message, string description, int code)
            : base(message)
        {
            this.code = code;
            this.description = description;
        }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public int Code
        {
            get => this.code;
        }

        /// <summary>
        /// Gets the description.
        /// </summary>
        public string Description
        {
            get => this.description;
        }
    }
}
