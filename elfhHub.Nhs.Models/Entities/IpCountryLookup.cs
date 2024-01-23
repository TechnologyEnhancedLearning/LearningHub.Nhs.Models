// <copyright file="IpCountryLookup.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The ip country lookup.
    /// </summary>
    public class IpCountryLookup
    {
        /// <summary>
        /// Gets or sets the from IP.
        /// </summary>
        public string FromIp { get; set; }

        /// <summary>
        /// Gets or sets the to IP.
        /// </summary>
        public string ToIp { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the From Int.
        /// </summary>
        public long? FromInt { get; set; }

        /// <summary>
        /// Gets or sets the ToInt.
        /// </summary>
        public long? ToInt { get; set; }
    }
}