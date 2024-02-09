namespace LearningHub.Nhs.Models.Hierarchy
{
    using System.Collections.Generic;

    /// <summary>
    /// The catalogue locations view model.
    /// </summary>
    public class CatalogueLocationsViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the catalogue locations.
        /// </summary>
        public List<CatalogueLocationViewModel> CatalogueLocations { get; set; }
    }
}
