namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The RatingSummaryViewModel.
    /// </summary>
    public partial class RatingSummaryViewModel
    {
        /// <summary>
        /// Gets or sets the entity version id. Currently always a ResourceVersion, but could be a NodeVersion in the future.
        /// </summary>
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

        /// <summary>
        /// Gets or sets the current user's star rating for the entity.
        /// </summary>
        public int UserRating { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user is the entity's contributor.
        /// </summary>
        public bool UserIsContributor { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user can rate the entity.
        /// </summary>
        public bool UserCanRate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the current user has already rated the entity.
        /// </summary>
        public bool UserHasAlreadyRated { get; set; }
    }
}
