namespace LearningHub.Nhs.Models.Common
{
    using System.Collections.Generic;

    /// <summary>
    /// The paged result set.
    /// </summary>
    /// <typeparam name="T">Input type.</typeparam>
    public class PagedResultSet<T>
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public List<T> Items { get; set; }

        /// <summary>
        /// Gets or sets the total item count.
        /// </summary>
        public int TotalItemCount { get; set; }
    }
}
