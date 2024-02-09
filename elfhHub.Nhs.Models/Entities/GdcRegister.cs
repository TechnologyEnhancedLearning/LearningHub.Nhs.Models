namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The gdc register.
    /// </summary>
    public class GdcRegister
    {
        /// <summary>
        /// Gets or sets the reg number.
        /// </summary>
        public string RegNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether dentist.
        /// </summary>
        public bool Dentist { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the forenames.
        /// </summary>
        public string Forenames { get; set; }

        /// <summary>
        /// Gets or sets the honorifics.
        /// </summary>
        public string Honorifics { get; set; }

        /// <summary>
        /// Gets or sets the house name.
        /// </summary>
        public string HouseName { get; set; }

        /// <summary>
        /// Gets or sets the address line 1.
        /// </summary>
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2.
        /// </summary>
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or sets the address line 3.
        /// </summary>
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or sets the address line 4.
        /// </summary>
        public string AddressLine4 { get; set; }

        /// <summary>
        /// Gets or sets the town.
        /// </summary>
        public string Town { get; set; }

        /// <summary>
        /// Gets or sets the county.
        /// </summary>
        public string County { get; set; }

        /// <summary>
        /// Gets or sets the post code.
        /// </summary>
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the regdate.
        /// </summary>
        public string Regdate { get; set; }

        /// <summary>
        /// Gets or sets the qualifications.
        /// </summary>
        public string Qualifications { get; set; }

        /// <summary>
        /// Gets or sets the dcp titles.
        /// </summary>
        public string DcpTitles { get; set; }

        /// <summary>
        /// Gets or sets the specialties.
        /// </summary>
        public string Specialties { get; set; }

        /// <summary>
        /// Gets or sets the condition.
        /// </summary>
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the suspension.
        /// </summary>
        public string Suspension { get; set; }

        /// <summary>
        /// Gets or sets the date processed.
        /// </summary>
        public DateTimeOffset DateProcessed { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        public string Action { get; set; }
    }
}
