// <copyright file="RegistrationRequestViewModel.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    using System;
    using elfhHub.Nhs.Models.Enums;

    /// <summary>
    /// The registration request view model.
    /// </summary>
    public class RegistrationRequestViewModel
    {
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the UserRegistrationType.
        /// </summary>
        public UserRegistrationTypeEnum UserRegistrationType { get; set; } = UserRegistrationTypeEnum.FullAccess;

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the country id.
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Gets or sets the region id.
        /// </summary>
        public int? RegionId { get; set; }

        /// <summary>
        /// Gets or sets the preferred name.
        /// </summary>
        public string PreferredName { get; set; }

        /// <summary>
        /// Gets or sets the secondary email address.
        /// </summary>
        public string SecondaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the job role id.
        /// </summary>
        public int JobRoleId { get; set; }

        /// <summary>
        /// Gets or sets the grade id.
        /// </summary>
        public int GradeId { get; set; }

        /// <summary>
        /// Gets or sets the medical council number.
        /// </summary>
        public string MedicalCouncilNumber { get; set; }

        /// <summary>
        /// Gets or sets the specialty id.
        /// </summary>
        public int SpecialtyId { get; set; }

        /// <summary>
        /// Gets or sets the location start date.
        /// </summary>
        public DateTimeOffset LocationStartDate { get; set; }

        /// <summary>
        /// Gets or sets the location id.
        /// </summary>
        public int LocationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether self registration.
        /// </summary>
        public bool SelfRegistration { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether it is external user.
        /// </summary>
        public bool IsExternalUser { get; set; }

        /// <summary>
        /// Gets or sets the external system id.
        /// </summary>
        public int? ExternalSystemId { get; set; }
    }
}
