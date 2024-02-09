namespace LearningHub.Nhs.Models.Catalogue
{
    using LearningHub.Nhs.Models.Common;

    /// <summary>
    /// The CatalogueAdminsViewModel.
    /// </summary>
    public class CatalogueAdminsViewModel
    {
        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the admins.
        /// </summary>
        public PagedResultSet<CatalogueAdminViewModel> Admins { get; set; }
    }
}
