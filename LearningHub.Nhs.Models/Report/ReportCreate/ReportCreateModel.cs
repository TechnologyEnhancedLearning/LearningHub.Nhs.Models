// <copyright file="ReportCreateModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Report.ReportCreate
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Report;

    /// <summary>
    /// The ReportCreateModel class.
    /// </summary>
    public class ReportCreateModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportCreateModel"/> class.
        /// The report.
        /// </summary>
        public ReportCreateModel()
        {
            this.ReportPages = new List<ReportPageModel>();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the report type id.
        /// </summary>
        public int ReportTypeId { get; set; }

        /// <summary>
        /// Gets or sets the report pages.
        /// </summary>
        public ICollection<ReportPageModel> ReportPages { get; set; }
    }
}
