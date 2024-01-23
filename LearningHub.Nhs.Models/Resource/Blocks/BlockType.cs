// <copyright file="BlockType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Resource.Blocks
{
    /// <summary>
    /// Defines the <see cref="BlockType" />.
    /// </summary>
    public enum BlockType
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,

        /// <summary>
        /// Text.
        /// </summary>
        Text = 1,

        /// <summary>
        /// Whole-slide image.
        /// </summary>
        WholeSlideImage = 2,

        /// <summary>
        /// Media.
        /// </summary>
        Media = 3,

        /// <summary>
        /// Question.
        /// </summary>
        Question = 4,

        /// <summary>
        /// Page break.
        /// </summary>
        PageBreak = 5,

        /// <summary>
        /// Image Carousel.
        /// </summary>
        ImageCarousel = 6,
    }
}
