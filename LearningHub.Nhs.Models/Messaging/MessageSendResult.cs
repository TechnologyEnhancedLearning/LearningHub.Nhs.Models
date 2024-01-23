// <copyright file="MessageSendResult.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Messaging
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Validation;

    /// <summary>
    /// The MessageSendResult class.
    /// </summary>
    public class MessageSendResult : LearningHubValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendResult"/> class.
        /// </summary>
        public MessageSendResult()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendResult"/> class.
        /// </summary>
        /// <param name="success">The success.</param>
        public MessageSendResult(bool success = true)
            : base(success)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSendResult"/> class.
        /// </summary>
        /// <param name="details">The details.</param>
        /// <param name="success">The success.</param>
        public MessageSendResult(string details, bool success = false)
            : base()
        {
        }

        /// <summary>
        /// Gets or sets the message sent ids.
        /// </summary>
        public List<int> MessageSentIds { get; set; }

        /// <summary>
        /// Gets or sets the message failed ids.
        /// </summary>
        public List<int> MessageFailedIds { get; set; }
    }
}
