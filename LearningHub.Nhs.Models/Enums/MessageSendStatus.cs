// <copyright file="MessageSendStatus.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The MessageSendStatus enum.
    /// </summary>
    public enum MessageSendStatus
    {
        /// <summary>
        /// Pending.
        /// </summary>
        Pending = 0,

        /// <summary>
        /// Sending.
        /// </summary>
        Sending = 1,

        /// <summary>
        /// Sent.
        /// </summary>
        Sent = 2,

        /// <summary>
        /// Failed.
        /// </summary>
        Failed = 3,
    }
}
