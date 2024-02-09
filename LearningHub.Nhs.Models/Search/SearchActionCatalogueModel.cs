namespace LearningHub.Nhs.Models.Search
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The search action catalogue resource request model.
    /// </summary>
    public class SearchActionCatalogueModel : SearchActionResourceModel
    {
        /// <summary>
        /// Gets or sets the catalogue id.
        /// </summary>
        public int CatalogueId { get; set; }
    }
}
