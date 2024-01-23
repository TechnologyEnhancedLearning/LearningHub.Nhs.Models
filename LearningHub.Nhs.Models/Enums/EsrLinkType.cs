// <copyright file="EsrLinkType.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// Defines the EsrLinkType.
    /// </summary>
    public enum EsrLinkType
    {
        /// <summary>
        /// Defines the NotAvailable.
        /// </summary>
        NotAvailable = 1,

        /// <summary>
        /// Defines the CreatedUserOnly.
        /// </summary>
        CreatedUserOnly = 2,

        /// <summary>
        /// Defines the CreatedUserAndOtherEditors.
        /// </summary>
        CreatedUserAndOtherEditors = 3,

        /// <summary>
        /// Defines the EveryOne.
        /// </summary>
        EveryOne = 4,
    }
}
