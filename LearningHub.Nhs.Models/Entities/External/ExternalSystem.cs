namespace LearningHub.Nhs.Models.Entities.External
{
    /// <summary>
    /// The external system entity.
    /// </summary>
    public class ExternalSystem : EntityBase
    {
        /// <summary>
        /// Gets or sets the external system name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the tand cs.
        /// </summary>
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Gets or sets the secret key.
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the default user group id.
        /// </summary>
        public int? DefaultUserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the default staff group id.
        /// </summary>
        public int? DefaultStaffGroupId { get; set; }

        /// <summary>
        /// Gets or sets the default job role id.
        /// </summary>
        public int? DefaultJobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the default grading id.
        /// </summary>
        public int? DefaultGradingId { get; set; }

        /// <summary>
        /// Gets or sets the default speciality id.
        /// </summary>
        public int? DefaultSpecialityId { get; set; }

        /// <summary>
        /// Gets or sets the default location id.
        /// </summary>
        public int? DefaultLocationId { get; set; }

        /// <summary>
        /// Gets or sets the create user.
        /// </summary>
        public virtual User CreateUser { get; set; }

        /// <summary>
        /// Gets or sets the amend user.
        /// </summary>
        public virtual User AmendUser { get; set; }
    }
}