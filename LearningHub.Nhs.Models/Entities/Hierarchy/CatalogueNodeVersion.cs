namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The CatalogueNodeVersion.
    /// </summary>
    public class CatalogueNodeVersion : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogueNodeVersion"/> class.
        /// </summary>
        public CatalogueNodeVersion()
        {
            this.Keywords = new HashSet<CatalogueNodeVersionKeyword>();
        }

        /// <summary>
        /// Gets or sets the node version id.
        /// </summary>
        public int NodeVersionId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the badge url.
        /// </summary>
        public string BadgeUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue card image url.
        /// </summary>
        public string CardImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the banner url.
        /// </summary>
        public string BannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the certificate url.
        /// </summary>
        public string CertificateUrl { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the owner name.
        /// </summary>
        public string OwnerName { get; set; }

        /// <summary>
        /// Gets or sets the owner email address.
        /// </summary>
        public string OwnerEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        public CatalogueOrder Order { get; set; }

        /// <summary>
        /// Gets or sets the keywords.
        /// </summary>
        public ICollection<CatalogueNodeVersionKeyword> Keywords { get; set; }

        /// <summary>
        /// Gets or sets the catalogue node version provider.
        /// </summary>
        public virtual CatalogueNodeVersionProvider CatalogueNodeVersionProvider { get; set; }

        /// <summary>
        /// Gets or sets the node version.
        /// </summary>
        public virtual NodeVersion NodeVersion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the catalogue is restricted access.
        /// </summary>
        public bool RestrictedAccess { get; set; }
    }
}
