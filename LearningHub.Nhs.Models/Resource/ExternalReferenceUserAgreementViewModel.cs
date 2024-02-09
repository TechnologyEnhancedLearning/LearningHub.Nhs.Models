namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// Defines the <see cref="ExternalReferenceUserAgreementViewModel" />.
    /// </summary>
    public class ExternalReferenceUserAgreementViewModel
    {
        /// <summary>
        /// Gets or sets the scorm resource version id...
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the ExternalReferenceId.
        /// </summary>
        public int ExternalReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        public int UserId { get; set; }
    }
}
