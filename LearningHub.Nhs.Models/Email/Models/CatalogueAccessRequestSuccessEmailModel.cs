// <copyright file="CatalogueAccessRequestSuccessEmailModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Email.Models
{
    /// <summary>
    /// The CatalogueAccessRequestSuccessEmailModel class.
    /// </summary>
    public class CatalogueAccessRequestSuccessEmailModel
    {
        /// <summary>
        /// Gets or sets the first name of the user who requested access.
        /// </summary>
        public string UserFirstName { get; set; }

        /// <summary>
        /// Gets or sets the full url to the catalogue.
        /// </summary>
        public string CatalogueUrl { get; set; }

        /// <summary>
        /// Gets or sets the catalogue name.
        /// </summary>
        public string CatalogueName { get; set; }
    }
}
