// <copyright file="Country.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The country.
    /// </summary>
    public class Country : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the alpha 2.
        /// </summary>
        public string Alpha2 { get; set; }

        /// <summary>
        /// Gets or sets the alpha 3.
        /// </summary>
        public string Alpha3 { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        public string Numeric { get; set; }

        /// <summary>
        /// Gets or sets the eu vat rate.
        /// </summary>
        public double EUVatRate { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }
    }
}
