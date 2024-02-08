namespace LearningHub.Nhs.Models.Resource
{
    using System.Collections.Generic;
    using LearningHub.Nhs.Models.Enums;

    /// <summary>
    /// The resource version validation result view model.
    /// </summary>
    public class ResourceVersionValidationResultViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceVersionValidationResultViewModel"/> class.
        /// </summary>
        public ResourceVersionValidationResultViewModel()
        {
            this.ResourceVersionValidationRuleResultViewModels = new List<ResourceVersionValidationRuleResultViewModel>();
        }

        /// <summary>
        /// Gets or sets the scorm resource version id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the resource version id.
        /// </summary>
        public int ResourceVersionId { get; set; }

        /// <summary>
        /// Gets or sets the resource version title.
        /// </summary>
        public string ResourceVersionTitle { get; set; }

        /// <summary>
        /// Gets or sets the version description.
        /// </summary>
        public string VersionDescription { get; set; }

        /// <summary>
        /// Gets or sets the resource version validation rule results.
        /// </summary>
        public virtual ICollection<ResourceVersionValidationRuleResultViewModel> ResourceVersionValidationRuleResultViewModels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the validation result was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the details.
        /// </summary>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the CreateUser.
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int ResourceVersionCreateUserId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether has publised version.
        /// </summary>
        public bool HasPublishedVersion { get; set; }

        /// <summary>
        ///  Gets or sets the Version Status.
        /// </summary>
        public VersionStatusEnum VersionStatus { get; set; }
    }
}
