// <copyright file="CatalogueAccessRequestFailureEmailModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Email.Models
{
    /// <summary>
    /// The CatalogueAccessRequestFailureEmailModel class.
    /// </summary>
    public class CatalogueAccessRequestFailureEmailModel
    {
        /// <summary>
        /// Gets or sets the user first name.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }

        /// <summary>
        /// Gets or sets the catalogue url.
        /// </summary>
        public string CatalogueUrl { get; set; }

        /// <summary>
        /// Gets or sets the rejection reason.
        /// </summary>
        public string RejectionReason { get; set; }
    }
}
