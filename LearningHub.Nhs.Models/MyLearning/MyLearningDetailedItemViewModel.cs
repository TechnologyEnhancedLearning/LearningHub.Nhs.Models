namespace LearningHub.Nhs.Models.MyLearning
{
    using System;

    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The My Learning request model.
    /// </summary>
    public class MyLearningDetailedItemViewModel
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ResourceId.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the ResourceReferenceId.
        /// </summary>
        public int ResourceReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the assessment resource activity id.
        /// </summary>
        public int AssessmentResourceActivityId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity is for the current resource version.
        /// </summary>
        public bool IsCurrentResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets the MajorVersion.
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// Gets or sets the MinorVersion.
        /// </summary>
        public int MinorVersion { get; set; }

        /// <summary>
        /// Gets or sets the Version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the ResourceType.
        /// </summary>
        public ResourceTypeEnum ResourceType { get; set; }

        /// <summary>
        /// Gets or sets the ActivityDate.
        /// </summary>
        public DateTimeOffset ActivityDate { get; set; }

        /// <summary>
        /// Gets or sets the ResourceDurationMilliseconds.
        /// </summary>
        public int ResourceDurationMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the DurationSeconds.
        /// </summary>
        public int ActivityDurationSeconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity has been completed.
        /// </summary>
        public bool Complete { get; set; }

        /// <summary>
        /// Gets or sets the CompletionPercentage.
        /// </summary>
        public int CompletionPercentage { get; set; }

        /// <summary>
        /// Gets or sets the activity status.
        /// </summary>
        public ActivityStatusEnum ActivityStatus { get; set; }

        /// <summary>
        /// Gets or sets the ScorePercentage.
        /// </summary>
        public int ScorePercentage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the activity has a certificate.
        /// </summary>
        public bool CertificateEnabled { get; set; }

        /// <summary>
        /// Gets or sets the certificate url.
        /// </summary>
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets the mastery score.
        /// </summary>
        public decimal? MasteryScore { get; set; }

        /// <summary>
        /// Gets or sets the VersionStatusId.
        /// </summary>
        public int? VersionStatusId { get; set; }

        /// <summary>
        /// Gets or sets the Assessment details.
        /// </summary>
        public MyLearningAssessmentDetails AssessmentDetails { get; set; }
    }
}
