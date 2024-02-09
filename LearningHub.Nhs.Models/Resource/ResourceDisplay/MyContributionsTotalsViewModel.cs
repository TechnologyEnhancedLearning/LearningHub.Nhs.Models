namespace LearningHub.Nhs.Models.Resource.ResourceDisplay
{
    /// <summary>
    /// The my contributions view model.
    /// </summary>
    public class MyContributionsTotalsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MyContributionsTotalsViewModel"/> class.
        /// </summary>
        public MyContributionsTotalsViewModel()
        {
        }

        /// <summary>
        /// Gets or sets the action required count.
        /// </summary>
        public int ActionRequiredCount { get; set; }

        /// <summary>
        /// Gets or sets the user action required count.
        /// </summary>
        public int UserActionRequiredCount { get; set; }

        /// <summary>
        /// Gets or sets the draft count.
        /// </summary>
        public int DraftCount { get; set; }

        /// <summary>
        /// Gets or sets the user draft count.
        /// </summary>
        public int UserDraftCount { get; set; }

        /// <summary>
        /// Gets or sets the published count.
        /// </summary>
        public int PublishedCount { get; set; }

        /// <summary>
        /// Gets or sets the user published count.
        /// </summary>
        public int UserPublishedCount { get; set; }

        /// <summary>
        /// Gets or sets the unpublished count.
        /// </summary>
        public int UnpublishedCount { get; set; }

        /// <summary>
        /// Gets or sets the user unpublished count.
        /// </summary>
        public int UserUnpublishedCount { get; set; }
    }
}
