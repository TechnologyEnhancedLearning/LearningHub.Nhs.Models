// <copyright file="PagingRequestModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Paging
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Common;

    /// <summary>
    /// The paging request model.
    /// </summary>
    public class PagingRequestModel
    {
        /// <summary>
        /// Gets or sets the page.
        /// </summary>
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets the sort column.
        /// </summary>
        public string SortColumn { get; set; }

        /// <summary>
        /// Gets or sets the sort direction.
        /// </summary>
        public string SortDirection { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        public List<PagingColumnFilter> PresetFilter { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        public List<PagingColumnFilter> Filter { get; set; }

        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        public int PageSize { get; set; }
    }
}
