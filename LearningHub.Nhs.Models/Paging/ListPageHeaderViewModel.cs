// <copyright file="ListPageHeaderViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Paging
{
    /// <summary>
    /// The list page header view model.
    /// </summary>
    public class ListPageHeaderViewModel
    {
        /// <summary>
        /// Gets or sets the displayed count.
        /// </summary>
        public int DisplayedCount { get; set; }

        /// <summary>
        /// Gets or sets the Default Page Size.
        /// </summary>
        public int DefaultPageSize { get; set; }

        /// <summary>
        /// Gets or sets the total item count.
        /// </summary>
        public int TotalItemCount { get; set; }

        /// <summary>
        /// Gets or sets the filter count.
        /// </summary>
        public int FilterCount { get; set; }

        /// <summary>
        /// Gets or sets the no results message.
        /// </summary>
        public string NoResultsMessage { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether create required.
        /// </summary>
        public bool CreateRequired { get; set; }
    }
}
