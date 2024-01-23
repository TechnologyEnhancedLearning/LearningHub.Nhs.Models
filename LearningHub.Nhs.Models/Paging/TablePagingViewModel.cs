// <copyright file="TablePagingViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Paging
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Common;

    /// <summary>
    /// The table paging view model.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    public class TablePagingViewModel<T>
    {
        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        public PagedResultSet<T> Results { get; set; }

        /// <summary>
        /// Gets or sets the paging.
        /// </summary>
        public PagingViewModel Paging { get; set; }

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
        public List<PagingColumnFilter> Filter { get; set; }

        /// <summary>
        /// Gets or sets the list page header.
        /// </summary>
        public ListPageHeaderViewModel ListPageHeader { get; set; }
    }
}
