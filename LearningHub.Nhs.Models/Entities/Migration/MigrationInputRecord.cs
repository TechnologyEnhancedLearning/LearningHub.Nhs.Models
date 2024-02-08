namespace LearningHub.Nhs.Models.Entities.Migration
{
    using LearningHub.Nhs.Models.Entities.Resource;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The migration input record.
    /// </summary>
    public partial class MigrationInputRecord : EntityBase
    {
        /// <summary>
        /// Gets or sets the migration id.
        /// </summary>
        public int MigrationId { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Gets or sets the record reference.
        /// </summary>
        public string RecordReference { get; set; }

        /// <summary>
        /// Gets or sets the record title.
        /// </summary>
        public string RecordTitle { get; set; }

        /// <summary>
        /// Gets or sets the ScormEsrLinkUrl, if applicable.
        /// </summary>
        public string ScormEsrLinkUrl { get; set; }

        /// <summary>
        /// Gets or sets the validation errors.
        /// </summary>
        public string ValidationErrors { get; set; }

        /// <summary>
        /// Gets or sets the validation warnings.
        /// </summary>
        public string ValidationWarnings { get; set; }

        /// <summary>
        /// Gets or sets the exception details.
        /// </summary>
        public string ExceptionDetails { get; set; }

        /// <summary>
        /// Gets or sets the id of the ResourceVersion that this MigrationInputRecord was responsible for creating.
        /// </summary>
        public int? ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the migration input record status enum.
        /// </summary>
        public virtual MigrationInputRecordStatusEnum MigrationInputRecordStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the migration.
        /// </summary>
        public virtual Migration Migration { get; set; }

        /// <summary>
        /// Gets or sets the ResourceVersion that this migration input record was responsible for creating.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
