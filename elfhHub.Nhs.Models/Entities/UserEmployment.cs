namespace elfhHub.Nhs.Models.Entities
{
    using System;

    /// <summary>
    /// The user employment.
    /// </summary>
    public class UserEmployment : EntityBase
    {
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

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the job role.
        /// </summary>
        public virtual JobRole JobRole { get; set; }

        /// <summary>
        /// Gets or sets the specialty.
        /// </summary>
        public virtual Specialty Specialty { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        public virtual Grade Grade { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public virtual Location Location { get; set; }

        /// <summary>
        /// Gets or sets the medical council.
        /// </summary>
        public virtual MedicalCouncil MedicalCouncil { get; set; }
    }
}
