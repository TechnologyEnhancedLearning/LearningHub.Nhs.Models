// <copyright file="EmailDetails.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace LearningHub.Nhs.Models.Email
{
    /// <summary>
    /// The EmailDetails.
    /// </summary>
    public class EmailDetails
    {
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the userId.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the userGroupId.
        /// </summary>
        public int UserGroupId { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        public string Body { get; set; }
    }
}
