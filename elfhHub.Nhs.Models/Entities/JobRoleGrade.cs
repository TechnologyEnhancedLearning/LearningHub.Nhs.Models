namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The job role grade.
    /// </summary>
    public partial class JobRoleGrade : EntityBase
    {
        /// <summary>
        /// Gets or sets the job role id.
        /// </summary>
        public int JobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the grade id.
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// Gets or sets the job role.
        /// </summary>
        public virtual JobRole JobRole { get; set; }

        /// <summary>
        /// Gets or sets the grade.
        /// </summary>
        public virtual Grade Grade { get; set; }
    }
}
