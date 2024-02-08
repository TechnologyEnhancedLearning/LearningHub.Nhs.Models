namespace LearningHub.Nhs.Models.Resource
{
    /// <summary>
    /// The file type view model.
    /// </summary>
    public class FileTypeViewModel
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the default resource type id.
        /// </summary>
        public int DefaultResourceTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether not allowed.
        /// </summary>
        public bool NotAllowed { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        public string Icon { get; set; }
    }
}
