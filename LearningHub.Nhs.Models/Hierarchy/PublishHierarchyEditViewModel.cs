namespace LearningHub.Nhs.Models.Hierarchy
{
    /// <summary>
    /// The publish hierarchy edit view model.
    /// </summary>
    public class PublishHierarchyEditViewModel
    {
        /// <summary>
        /// Gets or sets the hierarchy edit id.
        /// </summary>
        public int HierarchyEditId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is major revision.
        /// </summary>
        public bool IsMajorRevision { get; set; }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }
    }
}
