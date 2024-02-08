namespace elfhHub.Nhs.Models.Common
{
    using System;

    /// <summary>
    /// The user employment view model.
    /// </summary>
    public class UserEmploymentViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the job role id.
        /// </summary>
        public int? JobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the specialty id.
        /// </summary>
        public int? SpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the grade id.
        /// </summary>
        public int? GradeId { get; set; }

        /// <summary>
        /// Gets or sets the school id.
        /// </summary>
        public int? SchoolId { get; set; }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or sets the medical council id.
        /// </summary>
        public int? MedicalCouncilId { get; set; }

        /// <summary>
        /// Gets or sets the medical council no.
        /// </summary>
        public string MedicalCouncilNo { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether archived.
        /// </summary>
        public bool Archived { get; set; }
    }
}
