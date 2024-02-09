namespace LearningHub.Nhs.Models.Catalogue
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// CatalogueResourceRequestViewModel.
    /// </summary>
    public class CatalogueResourceRequestViewModel
    {
        /// <summary>
        /// Gets or sets nodeId.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets offset.
        /// </summary>
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets catalogueOrder.
        /// </summary>
        public CatalogueOrder CatalogueOrder { get; set; }
    }
}