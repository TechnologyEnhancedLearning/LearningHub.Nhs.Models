namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// The job role basic view model.
    /// </summary>
    public class JobRoleBasicViewModel
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
        /// Gets or sets the name with staff group.
        /// </summary>
        public string NameWithStaffGroup { get; set; }

        /// <summary>
        /// Gets or sets the medical council id.
        /// </summary>
        public int MedicalCouncilId { get; set; }

        /// <summary>
        /// Gets or sets the medical council name.
        /// </summary>
        public string MedicalCouncilName { get; set; }

        /// <summary>
        /// Gets or sets the medical council code.
        /// </summary>
        public string MedicalCouncilCode { get; set; }
    }
}
