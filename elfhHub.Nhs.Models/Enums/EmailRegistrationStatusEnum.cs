// <copyright file="EmailRegistrationStatusEnum.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Enums
{
    /// <summary>
    /// The email registration status.
    /// </summary>
    public enum EmailRegistrationStatus
    {
        /// <summary>
        /// The unknown.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// The new user not eligable.
        /// </summary>
        NewUserNotEligible = 1,

        /// <summary>
        /// The existing user not eligable.
        /// </summary>
        ExistingUserNotEligible = 2,

        /// <summary>
        /// The existing user is eligable.
        /// </summary>
        ExistingUserIsEligible = 3,

        /// <summary>
        /// The new user is eligable.
        /// </summary>
        NewUserIsEligible = 4,

        /// <summary>
        /// The new general user is eligable.
        /// </summary>
        NewGeneralUserIsEligible = 5,

        /// <summary>
        /// The ip adddress is not from UK.
        /// </summary>
        NonUKLocation = 6,
    }
}
