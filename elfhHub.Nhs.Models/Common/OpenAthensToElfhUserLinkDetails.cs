// <copyright file="OpenAthensToElfhUserLinkDetails.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Common
{
    /// <summary>
    /// The open athens to elfh user link details.
    /// </summary>
    public class OpenAthensToElfhUserLinkDetails
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the oa user id.
        /// </summary>
        public string OaUserId { get; set; }

        /// <summary>
        /// Gets or sets the oa org id.
        /// </summary>
        public string OaOrgId { get; set; }
    }
}
