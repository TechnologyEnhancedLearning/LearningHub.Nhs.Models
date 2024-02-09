namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The duplicate resource request model.
    /// </summary>
    public class DuplicateResourceRequestModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource catalogue id.
        /// </summary>
        public int ResourceCatalogueId { get; set; }
    }
}