namespace LearningHub.Nhs.Models.Common
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The RatingSummaryBasicViewModel.
    /// </summary>
    public partial class RatingSummaryBasicViewModel
    {
        /// <summary>
        /// Gets or sets the entity version id. Currently always a ResourceVersion, but could be a NodeVersion in the future.
        /// </summary>
        [Key]
        public int EntityVersionId { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public double AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the rating count.
        /// </summary>
        public int RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the 1 star rating percentage.
        /// </summary>
        public int Rating1StarPercent { get; set; }

        /// <summary>
        /// Gets or sets the 2 star rating percentage.
        /// </summary>
        public int Rating2StarPercent { get; set; }

        /// <summary>
        /// Gets or sets the 3 star rating percentage.
        /// </summary>
        public int Rating3StarPercent { get; set; }

        /// <summary>
        /// Gets or sets the 4 star rating percentage.
        /// </summary>
        public int Rating4StarPercent { get; set; }

        /// <summary>
        /// Gets or sets the 5 star rating percentage.
        /// </summary>
        public int Rating5StarPercent { get; set; }
    }
}
