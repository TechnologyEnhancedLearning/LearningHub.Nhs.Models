namespace LearningHub.Nhs.Models.Dashboard
{
    using System.Collections.Generic;

    /// <summary>
    /// ResourceResponseViewModel.
    /// </summary>
    public class DashboardResourceResponseViewModel : DashboardBaseViewModel
    {
        /// <summary>
        /// Gets or sets Resources.
        /// </summary>
        public List<DashboardResourceViewModel> Resources { get; set; }
    }
}
