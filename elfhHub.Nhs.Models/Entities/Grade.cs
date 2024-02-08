namespace elfhHub.Nhs.Models.Entities
{
    using System.Collections.Generic;

    /// <summary>
    /// The grade.
    /// </summary>
    public class Grade : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Grade"/> class.
        /// </summary>
        public Grade()
        {
            this.JobRoleGrade = new HashSet<JobRoleGrade>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display order.
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Gets or sets the job role grade.
        /// </summary>
        public virtual ICollection<JobRoleGrade> JobRoleGrade { get; set; }
    }
}
