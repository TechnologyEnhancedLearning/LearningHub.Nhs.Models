namespace LearningHub.Nhs.Models.Common
{
    /// <summary>
    /// The RatingViewModel.
    /// </summary>
    public partial class RatingViewModel
    {
        /// <summary>
        /// Gets or sets the entity version id. Currently always a ResourceVersionId, but could be a NodeVersionId in the future.
        /// </summary>
        public int EntityVersionId { get; set; }

        /// <summary>
        /// Gets or sets the average rating.
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Gets or sets the jobrole id.
        /// </summary>
        public int? JobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        public int LocationId { get; set; }
    }
}
