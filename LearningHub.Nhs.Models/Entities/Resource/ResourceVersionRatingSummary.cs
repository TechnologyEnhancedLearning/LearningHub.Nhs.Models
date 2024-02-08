namespace LearningHub.Nhs.Models.Entities.Resource
{
    /// <summary>
    /// The resource version rating summary.
    /// </summary>
    public partial class ResourceVersionRatingSummary : EntityBase
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public decimal AverageRating { get; set; }

        /// <summary>
        /// Gets or sets the rating count.
        /// </summary>
        public int RatingCount { get; set; }

        /// <summary>
        /// Gets or sets the 1 star rating count.
        /// </summary>
        public int Rating1StarCount { get; set; }

        /// <summary>
        /// Gets or sets the 2 star rating count.
        /// </summary>
        public int Rating2StarCount { get; set; }

        /// <summary>
        /// Gets or sets the 3 star rating count.
        /// </summary>
        public int Rating3StarCount { get; set; }

        /// <summary>
        /// Gets or sets the 4 star rating count.
        /// </summary>
        public int Rating4StarCount { get; set; }

        /// <summary>
        /// Gets or sets the 5 star rating count.
        /// </summary>
        public int Rating5StarCount { get; set; }

        /// <summary>
        /// Gets or sets the resource version.
        /// </summary>
        public virtual ResourceVersion ResourceVersion { get; set; }
    }
}
