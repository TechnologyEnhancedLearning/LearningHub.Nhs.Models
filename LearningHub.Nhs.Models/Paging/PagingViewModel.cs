// <copyright file="PagingViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Paging
{
    using System;

    /// <summary>
    /// The paging view model.
    /// </summary>
    public class PagingViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether has items.
        /// </summary>
        public bool HasItems { get; set; }

        /// <summary>
        /// Gets or sets the current page.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets the page size.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total items.
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// Gets the total pages.
        /// </summary>
        public int TotalPages
        {
            get
            {
                if (this.PageSize == 0)
                {
                    return 0;
                }

                return (this.TotalItems % this.PageSize > 0 ? 1 : 0) + (int)Math.Floor((decimal)this.TotalItems / (decimal)this.PageSize);
            }
        }
    }
}
