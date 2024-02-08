namespace LearningHub.Nhs.Models.Entities.Reporting
{
    using System.Collections.Generic;

    /// <summary>
    /// The Report class.
    /// </summary>
    public class Report : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Report"/> class.
        /// The report.
        /// </summary>
        public Report()
        {
            this.ReportPages = new HashSet<ReportPage>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the file name.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the hash.
        /// </summary>
        public string Hash { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        public virtual Client Client { get; set; }

        /// <summary>
        /// Gets or sets the report type id.
        /// </summary>
        public int ReportTypeId { get; set; }

        /// <summary>
        /// Gets or sets the report type.
        /// </summary>
        public virtual ReportType ReportType { get; set; }

        /// <summary>
        /// Gets or sets the report status id.
        /// </summary>
        public int ReportStatusId { get; set; }

        /// <summary>
        /// Gets or sets the report status.
        /// </summary>
        public virtual ReportStatus ReportStatus { get; set; }

        /// <summary>
        /// Gets or sets the report pages.
        /// </summary>
        public virtual ICollection<ReportPage> ReportPages { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }
    }
}
