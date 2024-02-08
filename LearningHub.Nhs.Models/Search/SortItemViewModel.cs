namespace LearningHub.Nhs.Models.Search
{
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The search item view model.
    /// </summary>
    public class SortItemViewModel
    {
        /// <summary>
        /// Gets or sets search sort type.
        /// </summary>
        public SearchSortTypeEnum SearchSortType { get; set; }

        /// <summary>
        /// Gets or sets the name string.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value string.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the sort direction string.
        /// </summary>
        public string SortDirection { get; set; }
    }
}
