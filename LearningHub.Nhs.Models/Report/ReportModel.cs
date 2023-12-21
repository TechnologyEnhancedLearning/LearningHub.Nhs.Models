// <copyright file="ReportModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Report
{
    using System.Collections.Generic;

    /// <summary>
    /// The ReportModel class.
    /// </summary>
    public class ReportModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportModel"/> class.
        /// The report.
        /// </summary>
        public ReportModel()
        {
            this.ReportPages = new List<ReportPageModel>();
        }

        /// <summary>
        /// Gets or sets the report id.
        /// </summary>
        public int Id { get; set; }

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
        /// Gets or sets the report type id.
        /// </summary>
        public int ReportTypeId { get; set; }

        /// <summary>
        /// Gets or sets the report status id.
        /// </summary>
        public int ReportStatusId { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the report pages.
        /// </summary>
        public ICollection<ReportPageModel> ReportPages { get; set; }
    }
}
