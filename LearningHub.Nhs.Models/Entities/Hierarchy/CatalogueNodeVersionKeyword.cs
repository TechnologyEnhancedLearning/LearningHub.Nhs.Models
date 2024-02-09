namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    /// <summary>
    /// The CatalogueNodeVersionKeyword.
    /// </summary>
    public class CatalogueNodeVersionKeyword : EntityBase
    {
        /// <summary>
        /// Gets or sets the catalogue node version id.
        /// </summary>
        public int CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the keyword.
        /// </summary>
        public string Keyword { get; set; }
    }
}
