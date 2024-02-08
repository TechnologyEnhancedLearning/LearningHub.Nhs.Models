namespace LearningHub.Nhs.Models.ExternalSystem
{
    using System;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The externalsystemviewmodel view model.
    /// </summary>
    public class ExternalSystemViewModel
    {
        /// <summary>
        /// Gets or sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [Required(ErrorMessage = "Enter a Name")]
        [StringLength(100, ErrorMessage = "The Name should be less than 100 characters including spaces.")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Code.
        /// </summary>
        [Required(ErrorMessage = "Enter a Code")]
        [StringLength(100, ErrorMessage = "The Code should be less than 100 characters including spaces.")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the CallbackUrl.
        /// </summary>
        [Required(ErrorMessage = "Enter a CallbackUrl")]
        [StringLength(100, ErrorMessage = "The CallbackUrl should be less than 100 characters including spaces.")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or sets the SecretKey.
        /// </summary>
        [Required(ErrorMessage = "Enter a SecretKey")]
        [StringLength(512, ErrorMessage = "The SecretKey should be less than 512 characters including spaces.")]
        public string SecretKey { get; set; }

        /// <summary>
        /// Gets or sets the TermsAndConditions.
        /// </summary>
        [Required(ErrorMessage = "Enter a TermsAndConditions")]
        public string TermsAndConditions { get; set; }

        /// <summary>
        /// Gets or sets the create user name.
        /// </summary>
        public string CreateUserName { get; set; }

        /// <summary>
        /// Gets or sets the amend user name.
        /// </summary>
        public string AmendUserName { get; set; }

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

        /// <summary>
        /// Gets or sets a value indicating whether deleted.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the create user id.
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// Gets or sets the create date.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTimeOffset CreateDate { get; set; }

        /// <summary>
        /// Gets or sets the amend user id.
        /// </summary>
        public int AmendUserId { get; set; }

        /// <summary>
        /// Gets or sets the amend date.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy HH:mm:ss}", ApplyFormatInEditMode = true)]
        public DateTimeOffset AmendDate { get; set; }
    }
}
