// <copyright file="UpdatePageSectionOrderModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Content
{
    using LearningHub.Nhs.Models.Enums.Content;

    /// <summary>
    /// Defines the <see cref="UpdatePageSectionOrderModel" />.
    /// </summary>
    public class UpdatePageSectionOrderModel
    {
        /// <summary>
        /// Gets or sets the PageId.
        /// </summary>
        public int PageId { get; set; }

        /// <summary>
        /// Gets or sets the PageSectionId.
        /// </summary>
        public int PageSectionId { get; set; }

        /// <summary>
        /// Gets or sets the DirectionType.
        /// </summary>
        public DirectionType DirectionType { get; set; }
    }
}
