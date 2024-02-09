namespace LearningHub.Nhs.Models.Dashboard
{
    using System.Collections.Generic;

    /// <summary>
    /// CatalogueResponseViewModel.
    /// </summary>
    public class DashboardMyLearningResponseViewModel : DashboardBaseViewModel
    {
        /// <summary>
        /// Gets or sets Catalogues.
        /// </summary>
        public List<DashboardCatalogueViewModel> Catalogues { get; set; }

        /// <summary>
        /// Gets or sets Resources.
        /// </summary>
        public List<DashboardResourceViewModel> Resources { get; set; }
    }
}
