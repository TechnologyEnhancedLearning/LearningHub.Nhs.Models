namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The job role.
    /// </summary>
    public class JobRole : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobRole"/> class.
        /// </summary>
        public JobRole()
        {
            this.JobRoleGrade = new HashSet<JobRoleGrade>();
        }

        /// <summary>
        /// Gets or sets the staff group id.
        /// </summary>
        public int? StaffGroupId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the medical council id.
        /// </summary>
        public int? MedicalCouncilId { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the staff group.
        /// </summary>
        public virtual StaffGroup StaffGroup { get; set; }

        /// <summary>
        /// Gets or sets the medical council.
        /// </summary>
        public virtual MedicalCouncil MedicalCouncil { get; set; }

        /// <summary>
        /// Gets or sets the job role grade.
        /// </summary>
        public virtual ICollection<JobRoleGrade> JobRoleGrade { get; set; }
    }
}
