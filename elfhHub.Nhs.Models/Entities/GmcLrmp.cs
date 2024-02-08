namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The gmc lrmp.
    /// </summary>
    public class GmcLrmp
    {
        /// <summary>
        /// Gets or sets the gmc ref no.
        /// </summary>
        public string GmcRefNo { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the given name.
        /// </summary>
        public string GivenName { get; set; }

        /// <summary>
        /// Gets or sets the year of qualification.
        /// </summary>
        public double YearOfQualification { get; set; }

        /// <summary>
        /// Gets or sets the gp register date.
        /// </summary>
        public string GPRegisterDate { get; set; }

        /// <summary>
        /// Gets or sets the registration status.
        /// </summary>
        public string RegistrationStatus { get; set; }

        /// <summary>
        /// Gets or sets the other names.
        /// </summary>
        public string OtherNames { get; set; }

        /// <summary>
        /// Gets or sets the date processed.
        /// </summary>
        public DateTime DateProcessed { get; set; }

        /// <summary>
        /// Gets or sets the action.
        /// </summary>
        public string Action { get; set; }
    }
}
