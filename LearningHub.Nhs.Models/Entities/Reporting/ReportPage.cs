// <copyright file="ReportPage.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>
namespace LearningHub.Nhs.Models.Entities.Reporting
{
    /// <summary>
    /// The Report Page class.
    /// </summary>
    public class ReportPage : EntityBase
    {
        /// <summary>
        /// Gets or sets the html.
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// Gets or sets the report orientation mode id.
        /// </summary>
        public int ReportOrientationModeId { get; set; }

        /// <summary>
        /// Gets or sets the report id.
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        /// Gets or sets the report orientation mode.
        /// </summary>
        public virtual ReportOrientationMode ReportOrientationMode { get; set; }

        /// <summary>
        /// Gets or sets the report.
        /// </summary>
        public virtual Report Report { get; set; }
    }
}
