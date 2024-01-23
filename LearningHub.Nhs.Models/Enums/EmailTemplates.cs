// <copyright file="EmailTemplates.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Enums
{
    /// <summary>
    /// The EmailTemplates enum, which maps template names to their ids.
    /// </summary>
    public enum EmailTemplates
    {
        /// <summary>
        /// The catalogue access request.
        /// </summary>
        CatalogueAccessRequest = 2000,

        /// <summary>
        /// The catalogue access request success.
        /// </summary>
        CatalogueAccessRequestSuccess = 2001,

        /// <summary>
        /// The catalogue access request failure.
        /// </summary>
        CatalogueAccessRequestFailure = 2002,

        /// <summary>
        /// The catalogue access invitation.
        /// </summary>
        CatalogueAccessInvitation = 2003,

        /// <summary>
        /// EmailChangeConfirmationEmail.
        /// </summary> .
        EmailChangeConfirmationEmail = 2004,

        /// <summary>
        /// EmailVerified.
        /// </summary> .
        EmailVerified = 2005,
    }
}
