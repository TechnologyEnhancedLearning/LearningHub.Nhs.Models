namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The generic file update request view model.
    /// </summary>
    public class GenericFileUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether scorm aicc content.
        /// </summary>
        public bool ScormAiccContent { get; set; }

        /// <summary>
        /// Gets or sets the authored year.
        /// </summary>
        public int? AuthoredYear { get; set; }

        /// <summary>
        /// Gets or sets the authored month.
        /// </summary>
        public int? AuthoredMonth { get; set; }

        /// <summary>
        /// Gets or sets the authored day of month.
        /// </summary>
        public int? AuthoredDayOfMonth { get; set; }
    }
}
