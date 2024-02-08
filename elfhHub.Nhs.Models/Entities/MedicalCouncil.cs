namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The medical council.
    /// </summary>
    public class MedicalCouncil : EntityBase
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the upload prefix.
        /// </summary>
        public string UploadPrefix { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether include on certs.
        /// </summary>
        public bool IncludeOnCerts { get; set; }
    }
}
