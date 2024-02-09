namespace LearningHub.Nhs.Models.Entities.Migration
{
    /// <summary>
    /// The migration source.
    /// </summary>
    public partial class MigrationSource : EntityBase
    {
        /// <summary>
        /// Gets or sets the Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the RootUrl.
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the RootUrl.
        /// </summary>
        public string ResourcePath { get; set; }

        /// <summary>
        /// Gets or sets the ResourceIdentifierPosition.
        /// </summary>
        public int ResourceIdentifierPosition { get; set; }

        /// <summary>
        /// Gets or sets the ResourceRegEx.
        /// </summary>
        public string ResourceRegEx { get; set; }

        /// <summary>
        /// Gets or sets the DefaultEsrLinkTypeId.
        /// </summary>
        public int? DefaultEsrLinkTypeId { get; set; }
    }
}
