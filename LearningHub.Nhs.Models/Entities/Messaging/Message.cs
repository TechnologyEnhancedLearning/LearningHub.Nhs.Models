// <copyright file="Message.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Messaging
{
    using System.Collections.Generic;

    /// <summary>
    /// The Message class.
    /// </summary>
    public class Message : EntityBase
    {
        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the message sends.
        /// </summary>
        public List<MessageSend> MessageSends { get; set; }

        /// <summary>
        /// Gets or sets the message meta data.
        /// </summary>
        public MessageMetaData MessageMetaData { get; set; }
    }
}
