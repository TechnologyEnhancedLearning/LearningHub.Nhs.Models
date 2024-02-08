namespace LearningHub.Nhs.Models.Entities.Migration
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Entities.Hierarchy;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The migration.
    /// </summary>
    public partial class Migration : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Migration"/> class.
        /// </summary>
        public Migration()
        {
            this.MigrationInputRecords = new HashSet<MigrationInputRecord>();
        }

        /// <summary>
        /// Gets or sets the migration source id.
        /// </summary>
        public int MigrationSourceId { get; set; }

        /// <summary>
        /// Gets or sets the destination node id.
        /// </summary>
        public int? DestinationNodeId { get; set; }

        /// <summary>
        /// Gets or sets the azure migration container name.
        /// </summary>
        public string AzureMigrationContainerName { get; set; }

        /// <summary>
        /// Gets or sets the metadata file name.
        /// </summary>
        public string MetadataFileName { get; set; }

        /// <summary>
        /// Gets or sets the metadata file path.
        /// </summary>
        public string MetadataFilePath { get; set; }

        /// <summary>
        /// Gets or sets the DefaultEsrLinkTypeId.
        /// </summary>
        public int? DefaultEsrLinkTypeId { get; set; }

        /// <summary>
        /// Gets or sets the migration status enum.
        /// </summary>
        public virtual MigrationStatusEnum MigrationStatusEnum { get; set; }

        /// <summary>
        /// Gets or sets the destination node.
        /// </summary>
        public virtual Node DestinationNode { get; set; }

        /// <summary>
        /// Gets or sets the migration source.
        /// </summary>
        public virtual MigrationSource MigrationSource { get; set; }

        /// <summary>
        /// Gets or sets the migration input records.
        /// </summary>
        public virtual ICollection<MigrationInputRecord> MigrationInputRecords { get; set; }
    }
}
