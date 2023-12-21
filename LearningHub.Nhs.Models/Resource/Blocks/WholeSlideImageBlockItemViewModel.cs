// <copyright file="WholeSlideImageBlockItemViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Blocks
{
    /// <summary>
    /// Defines the <see cref="WholeSlideImageBlockItemViewModel" />.
    /// </summary>
    public class WholeSlideImageBlockItemViewModel
    {
        /// <summary>
        /// Gets or sets the Order.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Gets or sets the WholeSlideImageViewModel.
        /// </summary>
        public virtual WholeSlideImageViewModel WholeSlideImage { get; set; }

        /// <summary>
        /// Gets or sets the PlaceholderText.
        /// </summary>
        public string PlaceholderText { get; set; }
    }
}