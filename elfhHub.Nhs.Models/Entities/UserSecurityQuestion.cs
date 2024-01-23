// <copyright file="UserSecurityQuestion.cs" company="HEE.nhs.uk">
// Copyright (c) HEE.nhs.uk.
// </copyright>

namespace elfhHub.Nhs.Models.Entities
{
    /// <summary>
    /// The user security question.
    /// </summary>
    public class UserSecurityQuestion : EntityBase
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the security question id.
        /// </summary>
        public int SecurityQuestionId { get; set; }

        /// <summary>
        /// Gets or sets the security question answer hash.
        /// </summary>
        public string SecurityQuestionAnswerHash { get; set; }

        /// <summary>
        /// Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets the security question.
        /// </summary>
        public virtual SecurityQuestion SecurityQuestion { get; set; }
    }
}
