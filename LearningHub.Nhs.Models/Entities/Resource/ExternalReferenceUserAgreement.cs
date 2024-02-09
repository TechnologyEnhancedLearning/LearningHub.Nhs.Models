namespace LearningHub.Nhs.Entities.Resource
{
    using LearningHub.Nhs.Models.Entities;

    /// <summary>
    /// Defines the <see cref="ExternalReferenceUserAgreement" />.
    /// </summary>
    public partial class ExternalReferenceUserAgreement : EntityBase
    {
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
