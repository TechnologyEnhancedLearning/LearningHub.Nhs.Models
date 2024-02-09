namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The image update request view model.
    /// </summary>
    public class ImageUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the alt tag.
        /// </summary>
        public string AltTag { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }
    }
}
