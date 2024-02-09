namespace LearningHub.Nhs.Models.Catalogue
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The Catalogue Owner ViewModel.
    /// </summary>
    public class CatalogueOwnerViewModel
    {
        /// <summary>
        /// Gets or sets the node id.
        /// </summary>
        public int NodeId { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node version id.
        /// </summary>
        public int CatalogueNodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        [Required]
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the owner email address.
        /// </summary>
        [Required]
        public string OwnerEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        [Required]
        public string Notes { get; set; }
    }
}
