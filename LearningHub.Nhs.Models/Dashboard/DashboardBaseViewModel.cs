// <copyright file="DashboardBaseViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Dashboard
{
    using System;

    /// <summary>
    /// The DashboardBaseViewModel.
    /// </summary>
    public class DashboardBaseViewModel
    {
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets the page size.
        /// </summary>
        public int PageItemSize => 3;

        /// <summary>
        ///  Gets or sets the current page.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets total pages.
        /// </summary>
        public int TotalPages => ((this.TotalCount % this.PageItemSize > 0) ? 1 : 0) + (int)Math.Floor(this.TotalCount / (decimal)this.PageItemSize);

        /// <summary>
        /// Gets or sets the total count.
        /// </summary>
        public int TotalCount { get; set; }
    }
}