namespace LearningHub.Nhs.Models.Report.ReportCreate
{
    using System;

    /// <summary>
    /// The RequestModel class.
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// Gets or sets the report create model.
        /// </summary>
        public ReportCreateModel ReportCreateModel { get; set; }

        /// <summary>
        /// Gets or sets the client Id.
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Gets or sets the user Id.
        /// </summary>
        public int UserId { get; set; }
    }
}
