// <copyright file="CatalogueAccessRequest.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Entities.Hierarchy
{
    using System;

    /// <summary>
    /// The CatalogueAccessRequest class.
    /// </summary>
    public class CatalogueAccessRequest : EntityBase
    {
        /// <summary>
        /// Gets or sets the id of the user requesting access.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the id of the catalogue node to which access is being requested.
        /// </summary>
        public int CatalogueNodeId { get; set; }

        /// <summary>
        /// Gets or sets the user's email address. Used for the reply email.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the response message.
        /// </summary>
        public string ResponseMessage { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the date completed.
        /// </summary>
        public DateTimeOffset? CompletedDate { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Gets or sets the user details.
        /// </summary>
        public UserProfile UserProfile { get; set; }
    }
}
