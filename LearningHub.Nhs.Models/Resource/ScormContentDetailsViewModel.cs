namespace LearningHub.Nhs.Models.Resource
{
    using System.ComponentModel.DataAnnotations;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// Defines the <see cref="ScormContentDetailsViewModel" />.
    /// </summary>
    public class ScormContentDetailsViewModel
    {
        /// <summary>
        /// Gets or sets the ExternalReferenceId.
        /// </summary>
        [Key]
        public int ExternalReferenceId { get; set; }

        /// <summary>
        /// Gets or sets the EsrLinkType.
        /// </summary>
        public EsrLinkType EsrLinkType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsOwnerOrEditor.
        /// </summary>
        public bool IsOwnerOrEditor { get; set; }

        /// <summary>
        /// Gets or sets the ContentFilePath.
        /// </summary>
        public string ContentFilePath { get; set; }

        /// <summary>
        /// Gets or sets the ExternalReference.
        /// </summary>
        public string ExternalReference { get; set; }

        /// <summary>
        /// Gets or sets the ManifestUrl.
        /// </summary>
        public string ManifestUrl { get; set; }

        /// <summary>
        /// Gets or sets the FullHistoricUrl.
        /// </summary>
        public string FullHistoricUrl { get; set; }

        /// <summary>
        /// Gets or sets the HostedContentUrl.
        /// </summary>
        public string HostedContentUrl { get; set; }
    }
}
