// <copyright file="MyLearningAssessmentDetails.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.MyLearning
{
    /// <summary>
    /// The My Learning Assessment details.
    /// </summary>
    public class MyLearningAssessmentDetails
    {
        /// <summary>
        /// Gets or sets the PassMark (as a percentage).
        /// </summary>
        public int? PassMark { get; set; }

        /// <summary>
        /// Gets or sets the Maximum number of attempts.
        /// </summary>
        public int? MaximumAttempts { get; set; }

        /// <summary>
        /// Gets or sets the current attempt.
        /// </summary>
        public int? CurrentAttempt { get; set; }

        /// <summary>
        /// Gets or sets the extra attempt reason.
        /// </summary>
        public string ExtraAttemptReason { get; set; }
    }
}
