namespace LearningHub.Nhs.Models.Dashboard
{
    using System.Collections.Generic;

    /// <summary>
    /// CatalogueResponseViewModel.
    /// </summary>
    public class DashboardCatalogueResponseViewModel : DashboardBaseViewModel
    {
        /// <summary>
        /// Gets or sets Catalogues.
        /// </summary>
        public List<DashboardCatalogueViewModel> Catalogues { get; set; }
    }
}
