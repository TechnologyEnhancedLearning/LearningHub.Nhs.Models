namespace LearningHub.Nhs.Models.Resource.Admin
{
    /// <summary>
    /// The transfer resource ownership view model.
    /// </summary>
    public class TransferResourceOwnershipViewModel
    {
        /// <summary>
        /// Gets or sets the resource id.
        /// </summary>
        public int ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the new owner username.
        /// </summary>
        public string NewOwnerUsername { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }
    }
}
