// <copyright file="LocationType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The location type.
    /// </summary>
    public class LocationType
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether health service.
        /// </summary>
        public bool HealthService { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether health board.
        /// </summary>
        public bool HealthBoard { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether primary trust.
        /// </summary>
        public bool PrimaryTrust { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether secondary trust.
        /// </summary>
        public bool SecondaryTrust { get; set; }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        [InverseProperty("Type")]
        public virtual ICollection<Location> Locations { get; set; }
    }
}
