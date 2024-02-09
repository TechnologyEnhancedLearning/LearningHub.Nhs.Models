namespace LearningHub.Nhs.Models.ExternalSystem
{
    /// <summary>
    /// The user notification view model.
    /// </summary>
    public class UserExternalSystemViewModel
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the CallbackUrl.
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the SecretKey.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the TermsAndConditions.
        /// </summary>
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Gets or sets the DefaultUserGroupId.
        /// </summary>
        public int? DefaultUserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultStaffGroupId.
        /// </summary>
        public int? DefaultStaffGroupId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultJobRoleId.
        /// </summary>
        public int? DefaultJobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultGradingId.
        /// </summary>
        public int? DefaultGradingId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultSpecialityId.
        /// </summary>
        public int? DefaultSpecialityId { get; set; }

        /// <summary>
        /// Gets or sets the DefaultLocationId.
        /// </summary>
        public int? DefaultLocationId { get; set; }
    }
}