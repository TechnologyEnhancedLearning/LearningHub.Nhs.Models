namespace LearningHub.Nhs.Models.Resource.Contribute
{
    /// <summary>
    /// The image update request view model.
    /// </summary>
    public class AudioUpdateRequestViewModel
    {
        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the duration in millseconds.
        /// </summary>
        public int? DurationInMilliseconds { get; set; }
    }
}
