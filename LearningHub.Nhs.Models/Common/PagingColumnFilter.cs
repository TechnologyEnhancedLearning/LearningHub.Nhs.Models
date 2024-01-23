// <copyright file="PagingColumnFilter.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Common
{
    using LearningHub.Nhs.Models.Common.Enums;

    /// <summary>
    /// The paging column filter.
    /// </summary>
    public class PagingColumnFilter
    {
        /// <summary>
        /// Gets or sets the column type.
        /// </summary>
        public PagingColumnType Type { get; set; }

        /// <summary>
        /// Gets or sets the column.
        /// </summary>
        public string Column { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        public string Value { get; set; }
    }
}
