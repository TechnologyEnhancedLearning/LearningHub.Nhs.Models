namespace LearningHub.Nhs.Models.Content
{
    using System.Collections.Generic;

    /// <summary>
    /// The PageViewModel.
    /// </summary>
    public class PageResultViewModel
    {
        /// <summary>
        /// Gets or sets the Pages.
        /// </summary>
        public List<PageViewModel> Pages { get; set; }

        /// <summary>
        /// Gets or sets the TotalCount.
        /// </summary>
        public int TotalCount { get; set; }
    }
}
