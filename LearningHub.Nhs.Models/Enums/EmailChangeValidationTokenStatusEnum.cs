// <copyright file="EmailChangeValidationTokenStatusEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// EmailChangeValidationTokenStatusEnum.
    /// </summary>
    public enum EmailChangeValidationTokenStatusEnum
    {
        /// <summary>
        /// Issued.
        /// </summary>
        Issued = 1,

        /// <summary>
        /// Abandoned.
        /// </summary>
        Abandoned = 2,

        /// <summary>
        /// Cancelled.
        /// </summary>
        Cancelled = 3,

        /// <summary>
        /// Completed.
        /// </summary>
        Completed = 4,
    }
}
