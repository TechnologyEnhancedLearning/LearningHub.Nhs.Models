namespace elfhHub.Nhs.Models.Entities
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The user.
    /// </summary>
    public class User : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            this.UserUserGroup = new HashSet<UserUserGroup>();
            this.UserEmployment = new HashSet<UserEmployment>();
            this.EmailLog = new HashSet<EmailLog>();
            this.LoginWizardStageActivity = new HashSet<LoginWizardStageActivity>();
            this.UserTermsAndConditions = new HashSet<UserTermsAndConditions>();
            this.UserSecurityQuestion = new HashSet<UserSecurityQuestion>();
            this.UserAttributes = new HashSet<UserAttribute>();
        }

        ////public int UserId { get; set; }
        ////public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the alt email address.
        /// </summary>
        public string AltEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the preferred name.
        /// </summary>
        public string PreferredName { get; set; }

        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        public int? CountryId { get; set; }

        /// <summary>
        /// Gets or sets the registration code.
        /// </summary>
        public string RegistrationCode { get; set; }

        /// <summary>
        /// Gets or sets the active from date.
        /// </summary>
        public DateTimeOffset? ActiveFromDate { get; set; }

        /// <summary>
        /// Gets or sets the active to date.
        /// </summary>
        public DateTimeOffset? ActiveToDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether active.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets the password hash.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether must change next login.
        /// </summary>
        public bool MustChangeNextLogin { get; set; }

        /// <summary>
        /// Gets or sets the password life counter.
        /// </summary>
        public int PasswordLifeCounter { get; set; }

        /// <summary>
        /// Gets or sets the security life counter.
        /// </summary>
        public int SecurityLifeCounter { get; set; }

        /// <summary>
        /// Gets or sets the remote login key.
        /// </summary>
        public string RemoteLoginKey { get; set; }

        /// <summary>
        /// Gets or sets the remote login guid.
        /// </summary>
        public Guid? RemoteLoginGuid { get; set; }

        /// <summary>
        /// Gets or sets the remote login start.
        /// </summary>
        public DateTimeOffset? RemoteLoginStart { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether restrict to sso.
        /// </summary>
        public bool RestrictToSso { get; set; }

        /// <summary>
        /// Gets or sets the active component hierarchy id.
        /// </summary>
        public int? ActiveComponentHierarchyId { get; set; }

        /// <summary>
        /// Gets or sets the active component hierarchy date.
        /// </summary>
        public DateTimeOffset? ActiveComponentHierarchyDate { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the login times.
        /// </summary>
        public int LoginTimes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether login wizard in progress.
        /// </summary>
        public bool LoginWizardInProgress { get; set; }

        /// <summary>
        /// Gets or sets the last login wizard completed.
        /// </summary>
        public DateTimeOffset? LastLoginWizardCompleted { get; set; }

        ////public bool Deleted { get; set; }
        ////public int AmendUserId { get; set; }
        ////public DateTimeOffset AmendDate { get; set; }

        /// <summary>
        /// Gets or sets the primary user employment id.
        /// </summary>
        public int? PrimaryUserEmploymentId { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred tenant id.
        /// </summary>
        public int PreferredTenantId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether admin request user logout.
        /// </summary>
        public bool AdminRequestUserLogout { get; set; }

        /// <summary>
        /// Gets or sets the user user group.
        /// </summary>
        public virtual ICollection<UserUserGroup> UserUserGroup { get; set; }

        /// <summary>
        /// Gets or sets the user password validation token.
        /// </summary>
        public virtual ICollection<UserPasswordValidationToken> UserPasswordValidationToken { get; set; }

        /// <summary>
        /// Gets or sets the user employment.
        /// </summary>
        public virtual ICollection<UserEmployment> UserEmployment { get; set; }

        /// <summary>
        /// Gets or sets the email log.
        /// </summary>
        public virtual ICollection<EmailLog> EmailLog { get; set; }

        /// <summary>
        /// Gets or sets the login wizard stage activity.
        /// </summary>
        public virtual ICollection<LoginWizardStageActivity> LoginWizardStageActivity { get; set; }

        /// <summary>
        /// Gets or sets the user terms and conditions.
        /// </summary>
        public virtual ICollection<UserTermsAndConditions> UserTermsAndConditions { get; set; }

        /// <summary>
        /// Gets or sets the user security question.
        /// </summary>
        public virtual ICollection<UserSecurityQuestion> UserSecurityQuestion { get; set; }

        /// <summary>
        /// Gets or sets the user attributes.
        /// </summary>
        public virtual ICollection<UserAttribute> UserAttributes { get; set; }

        /// <summary>
        /// Gets or sets the user attributes.
        /// </summary>
        public virtual ICollection<UserRoleUpgrade> UserRoleUpgrade { get; set; }
    }
}