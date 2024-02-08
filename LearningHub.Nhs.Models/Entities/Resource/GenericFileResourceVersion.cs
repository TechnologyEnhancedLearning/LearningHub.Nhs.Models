namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The generic file resource version.
    /// </summary>
    public partial class GenericFileResourceVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericFileResourceVersion"/> class.
        /// </summary>
        public GenericFileResourceVersion()
        {
        }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the file id.
        /// </summary>
        public int FileId { get; set; }

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

        /// <summary>
        /// Gets or sets the file.
        /// </summary>
        public virtual File File { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
